﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tower_Defense
{
    public class MainGame : Game
    {
        GraphicsDeviceManager myGraphics;
        SpriteBatch mySpriteBatch;

        State myGameState;

        public void ChangeState(State aNewState)
        {
            myGameState = aNewState;
            myGameState.LoadContent();
        }

        public MainGame()
        {
            myGraphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            myGraphics.PreferredBackBufferWidth = 1600;
            myGraphics.PreferredBackBufferHeight = 900;
            myGraphics.ApplyChanges();

            ResourceManager.Initialize();

            StringManager.Initialize();

            GameInfo.Initialize();
            GameInfo.FolderLevels = "../../../../Levels/Levels/";
            GameInfo.FolderLevelsInfo = "../../../../Levels/Levels_Info/";
            GameInfo.FolderHighScores = "../../../../Levels/HighScores/";

            Background.Initialize(12.0f);

            myGameState = new MenuState(this, Window);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            mySpriteBatch = new SpriteBatch(GraphicsDevice);

            ResourceManager.AddFont("8-bit", this.Content.Load<SpriteFont>("Fonts/8bit"));

            ResourceManager.AddTexture("Null", this.Content.Load<Texture2D>("Sprites/other/null"));

            ResourceManager.AddTexture("Border_Long", this.Content.Load<Texture2D>("Sprites/Main/border_long"));
            ResourceManager.AddTexture("Border_Short", this.Content.Load<Texture2D>("Sprites/Main/border_short"));
            ResourceManager.AddTexture("Border_Small", this.Content.Load<Texture2D>("Sprites/Main/border_small"));

            ResourceManager.AddTexture("Background", this.Content.Load<Texture2D>("Sprites/Main/background"));
            ResourceManager.AddTexture("Shop_Menu", this.Content.Load<Texture2D>("Sprites/Main/shop_menu"));

            for (int i = 0; i < 4; i++)
            {
                ResourceManager.AddTexture("Enemy_" + Extensions.NumberFormat(i), 
                    this.Content.Load<Texture2D>("Sprites/Main/enemy_" + Extensions.NumberFormat(i)));
            }
            ResourceManager.AddTexture("Healthbar", this.Content.Load<Texture2D>("Sprites/Main/healthbar"));

            for (int i = 0; i < 5; i++)
            {
                ResourceManager.AddTexture("Tile_" + Extensions.NumberFormat(i), this.Content.Load<Texture2D>("Sprites/Tileset/tile_" + Extensions.NumberFormat(i)));
            }

            Background.LoadContent();
            myGameState.LoadContent();
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime aGameTime)
        {
            KeyMouseReader.Update();

            StringManager.Update(aGameTime);

            Background.Update();

            myGameState.Update(aGameTime, Window);

            base.Update(aGameTime);
        }

        protected override void Draw(GameTime aGameTime)
        {
            GraphicsDevice.Clear(new Color(30, 30, 90));

            mySpriteBatch.Begin();

            Background.Draw(mySpriteBatch, aGameTime, Window);

            myGameState.Draw(mySpriteBatch, aGameTime, Window);

            mySpriteBatch.End();

            base.Draw(aGameTime);
        }
    }
}
