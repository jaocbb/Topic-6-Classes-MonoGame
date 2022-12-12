using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_6_Classes_MonoGame
{
    class Tribble
    {
        private Rectangle _rectangle;
        private Vector2 _speed;
        private Texture2D _texture;

        public Tribble(Rectangle recatngle, Vector2 speed, Texture2D texture)
        {
            _rectangle = recatngle;
            _speed = speed;
            _texture = texture;
        }
        public Texture2D Texture { get { return _texture; } }

        public Rectangle Bounds
        {
            get { return _rectangle; }
            set { _rectangle = value; }
        }
        public void Move(GraphicsDeviceManager graphics) 
        {
            _rectangle.Offset(_speed);
            if (_rectangle.Right > graphics.PreferredBackBufferWidth || _rectangle.Left < 0) 
             _speed.X *= -1;
            if (_rectangle.Bottom > graphics.PreferredBackBufferHeight || _rectangle.Top < 0)
                _speed.Y *= -1;
        }
        public void Draw(SpriteBatch spritebatch) 
        {
            spritebatch.Draw(_texture,_rectangle, Color.White);
        }
    }

}







    


