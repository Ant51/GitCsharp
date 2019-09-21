using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class FGame_Snake : Form
    {
        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400]; // хранение структуры змейки
        private Label labelScore; //счетчик очков
        private int dirX, dirY;
        private int _width =780;
        private int _height = 640;
        private int _sizeOfSides = 40;
        private int score = 0;
        public FGame_Snake()
        {
            InitializeComponent();
            this.Width = _width;
            this.Height = _height;
            dirX = 1;
            dirY = 0;
            labelScore = new Label(); // отображение счета в игре
            labelScore.Text = "Счет игры: 0";
            labelScore.Location = new Point(740, 10);
            this.Controls.Add(labelScore);
            snake[0] = new PictureBox(); //  1-я голова змейки
            snake[0].Location = new Point(201, 201);
            snake[0].Size = new Size(_sizeOfSides-1,_sizeOfSides-1);
            snake[0].BackColor = Color.Green;
            this.Controls.Add(snake[0]); // добавление элемента на форму
            fruit = new PictureBox();
            fruit.BackColor = Color.Yellow;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);
            _generateMap();
            _generateFruit();
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = 200;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(ОКР);
        }
        private void _generateFruit() // случайное появление фрукта на поле
        {
            Random r = new Random();
            rI = r.Next(0, _height - _sizeOfSides);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, _height - _sizeOfSides);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            rI++; // увеличение координат в генерации фруктов
            rJ++;
            fruit.Location = new Point(rI,rJ);
            this.Controls.Add(fruit);
        }

        private void _checkBorders() // выход змейки за границы карты
        {
            if (snake[0].Location.X < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Счет игры: " + score;
                dirX = 1;
            }
            if (snake[0].Location.X > _height)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Счет игры: " + score;
                dirX = -1;
            }
            if (snake[0].Location.Y < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Счет игры: " + score;
                dirY = 1;
            }
            if (snake[0].Location.Y > _height)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labelScore.Text = "Счет игры: " + score;
                dirY = -1;
            }
        }

        private void _eatItself() // событие, когда змейка врезается в саму себя
        {
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[0].Location == snake[_i].Location)
                {
                    for (int _j = _i; _j <= score; _j++)
                        this.Controls.Remove(snake[_j]);
                    score = score - (score - _i + 1);
                    labelScore.Text = "Счет игры: " + score;
                }
            }
        }

        private void _eatfruit() // поедание фрукта
        {
            if (snake[0].Location.X == rI && snake[0].Location.Y == rJ)
           {
               labelScore.Text = "Счет игры: "+ ++score;
               snake[score] = new PictureBox(); // рост змейки
               snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
               snake[score].Size = new Size(_sizeOfSides-1,_sizeOfSides);
               snake[score].BackColor = Color.Green;
               this.Controls.Add(snake[score]);
                _generateFruit();

           }
        }
        private void _generateMap() // построение карты движения змейки
        {
           for(int i = 0; i < (_width / _sizeOfSides)+10; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeOfSides * i);
                pic.Size = new Size(_width-100, 1);
                this.Controls.Add(pic);
            }

          for (int i = 0; i < (_height / _sizeOfSides)+5; i++)
           {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeOfSides * i, 0);
                pic.Size = new Size(1,_width);
                this.Controls.Add(pic);
           }

        }

        private void _moveSnake() // структура движения змеи
        {
            for(int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;         
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * _sizeOfSides,
            snake[0].Location.Y + dirY * _sizeOfSides);
            _eatItself();

        }
        private void _update(object myObject, EventArgs eventArgs) // процесс игры
        {
            _checkBorders();
            _eatfruit();
            _moveSnake();
  
        }
        private void ОКР(object sender, KeyEventArgs e) // обработчик нажатий с клавиатуры
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirX = 0;
                    dirY = -1;
                    break;
                case "Down":
                    dirX = 0;
                    dirY = 1;
                    break;
            }
        }

       
    }
}
