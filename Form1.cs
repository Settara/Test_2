using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ComputerGraphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float[,] LetterH;
        private float[,] proection;
        private float previousX = 0, previousX1 = 0;
        private float previousY = 0, previousY1 = 0;
        private float previousZ = 0, previousZ1 = 0;
        private int centerX;
        private int centerY;
        private Graphics graphics;
        private Timer rotationTimer;
        private int rotationCount = 0; 
        private const int totalRotations = 36; 
        private const float rotationStep = 10f; 

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Определяются цетра окна
            centerX = Size.Width / 2;
            centerY = Size.Height / 2;

            //Вызывается метод устанавливающие начальные коорлинаты для точек буквы H
            SetDefaultPosition();

            /* 
            Кабинетное проецирование относительно центра прямоугольной системы координат
            Вместо -Sin45 используется Cos45 так как в противном случае ось Z будет уходить в плоскость
            внутрь экрана
            */
            float[,] p =
            {
                { 1, 0, 0, 0},
                { 0, -1, 0, 0},
                { -(float)(Math.Cos(Math.PI/4))/2, (float)(Math.Cos(Math.PI/4))/2, 0, 0},  
                { centerX, centerY, 0, 1}
            };
            proection = p;

            //Вызывается метод для отрисовки проекции буквы
            DrawLetterH();
        }

        //Метод для умножения матриц  
        private float[,] MultiplyMatrices(float[,] X, float[,] Y)
        {
            float[,] result = new float[X.GetLength(0), Y.GetLength(1)];
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < Y.GetLength(1); j++)
                    for (int k = 0; k < Y.GetLength(0); k++)
                        result[i, j] += X[i, k] * Y[k, j];
            return result;
        }

        //Метод для отрисовки координатных осей
        private void DrawAxis()
        {
            graphics = CreateGraphics();
            graphics.Clear(Color.White);
            float[,] Axis =
            {
                { 0, 0, 0, 1},      // Начало оси (0, 0, 0) - точка
                { 500, 0, 0, 1},    // Конец оси X (500, 0, 0)
                { 0, 400, 0, 1},    // Конец оси Y (0, 400, 0)
                { 0, 0, 500, 1},    // Конец оси Z (0, 0, 500)
                { 490, 5, 0, 1},
                { 490, -5, 0, 1},
                { 5, 390, 0, 1},
                { -5, 390, 0, 1},
                { 12, 0, 495, 1},
                { -10, 0, 480, 1}
            };
            Axis = MultiplyMatrices(Axis, proection);

            // Ось X
            graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[1, 0], Axis[1, 1]); //Сама прямая линия
            graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[4, 0], Axis[4, 1]); //Левая стрелка
            graphics.DrawLine(Pens.Gray, Axis[1, 0], Axis[1, 1], Axis[5, 0], Axis[5, 1]); //Правая стрелка
            
            // Ось Y
            graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[2, 0], Axis[2, 1]); 
            graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[6, 0], Axis[6, 1]);
            graphics.DrawLine(Pens.Gray, Axis[2, 0], Axis[2, 1], Axis[7, 0], Axis[7, 1]);
           
            // Ось Z
            graphics.DrawLine(Pens.Gray, Axis[0, 0], Axis[0, 1], Axis[3, 0], Axis[3, 1]); 
            graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[8, 0], Axis[8, 1]);
            graphics.DrawLine(Pens.Gray, Axis[3, 0], Axis[3, 1], Axis[9, 0], Axis[9, 1]);
            
        }

        //Метод задает начальные координаты для точек, из которых будет строится буква H
        private void SetDefaultPosition()
        {
            float[,] H =
            {
                { 0, 0, 0, 1 },      // A - 0
                { 0, 100, 0, 1 },    // B - 1
                { 20, 100, 0, 1 },   // C - 2
                { 20, 60, 0, 1 },    // D - 3
                { 60, 60, 0, 1 },    // E - 4
                { 60, 100, 0, 1 },   // F - 5
                { 80, 100, 0, 1 },   // G - 6
                { 80, 0, 0, 1 },     // H - 7
                { 60, 0, 0, 1 },     // I - 8
                { 60, 40, 0, 1 },    // J - 9
                { 20, 40, 0, 1 },    // K - 10
                { 20, 0, 0, 1 },     // L - 11
                { 0, 0, 10, 1 },     // A' - 12
                { 0, 100, 10, 1 },   // B' - 13
                { 20, 100, 10, 1 },  // C' - 14
                { 20, 60, 10, 1 },   // D' - 15
                { 60, 60, 10, 1 },   // E' - 16
                { 60, 100, 10, 1 },  // F' - 17
                { 80, 100, 10, 1 },  // G' - 18
                { 80, 0, 10, 1 },    // H' - 19
                { 60, 0, 10, 1 },    // I' - 20
                { 60, 40, 10, 1 },   // J' - 21
                { 20, 40, 10, 1 },   // K' - 22
                { 20, 0, 10, 1 }     // L' - 23
            };

            LetterH = H;
        }

        //Метод для отрисовки проекции буквы
        private void DrawLetterH()
        {
            graphics = CreateGraphics();
            DrawAxis();
            float[,] matrixDraw = MultiplyMatrices(LetterH, proection);

            // Рисуем линии для нижней части буквы
            for (int i = 0; i < 11; i++)
            {
                if(i != 7)
                    graphics.DrawLine(Pens.Gold, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 1, 0], matrixDraw[i + 1, 1]);
            }

            // Рисуем линии для верхней части буквы
            for (int i = 12; i < 23; i++)
            {
                if(i != 19)
                    graphics.DrawLine(Pens.Gold, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 1, 0], matrixDraw[i + 1, 1]);
            }

            // Соединяем нижнюю и верхнюю части
            for (int i = 0; i < 12; i++) 
            {
                graphics.DrawLine(Pens.Gold, matrixDraw[i, 0], matrixDraw[i, 1], matrixDraw[i + 12, 0], matrixDraw[i + 12, 1]);
            }

            // Дополнительные соединения для завершения буквы
            graphics.DrawLine(Pens.Gold, matrixDraw[7, 0], matrixDraw[7, 1], matrixDraw[8, 0], matrixDraw[8, 1]); 
            graphics.DrawLine(Pens.Gold, matrixDraw[0, 0], matrixDraw[0, 1], matrixDraw[11, 0], matrixDraw[11, 1]);
            graphics.DrawLine(Pens.Gold, matrixDraw[19, 0], matrixDraw[19, 1], matrixDraw[20, 0], matrixDraw[20, 1]);
            graphics.DrawLine(Pens.Gold, matrixDraw[12, 0], matrixDraw[12, 1], matrixDraw[23, 0], matrixDraw[23, 1]);
        }

        /*
        Метод обрабатывает событие нажатия на кнопку buttonDeffaultPosition
        В результате буква перерисовывается в изначальном положении и первоначальном виде
        */
        private void buttonDeffaultPosition_Click(object sender, EventArgs e)
        {
            SetDefaultPosition();
            DrawLetterH();
        }

        
        //Метод передвигающий букву вдоль оси X
        private void MoveX_Click(object sender, EventArgs e, bool sign)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);

            int PlusOrMinus;
            if (sign)
                PlusOrMinus = 1;
            else
                PlusOrMinus = -1;

            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { PlusOrMinus * toMove, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Move);
            DrawLetterH();
        }

        
        //Метод передвигающий букву вдоль оси Y
        private void MoveY_Click(object sender, EventArgs e, bool sign)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);

            int PlusOrMinus;
            if (sign)
                PlusOrMinus = 1;
            else
                PlusOrMinus = -1;

            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, PlusOrMinus * toMove, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Move);
            DrawLetterH();
        }

        
        //Метод передвигающий букву вдоль оси Z
        private void MoveZ_Click(object sender, EventArgs e, bool sign)
        {
            int toMove = Convert.ToInt32(MoveTextBox.Text);

            int PlusOrMinus;
            if (sign)
                PlusOrMinus = 1;
            else
                PlusOrMinus = -1;

            float[,] Move =
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, PlusOrMinus * toMove, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Move);
            DrawLetterH();
        }

        
        //Метод вращает букву вдоль оси X в обе стороны
        private void RotateX_Click(object sender, EventArgs e, string way)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            float angle = (float)(toRotate * Math.PI / 180); // Перевод в радианы

            int sign;
            if (way == "right")
                sign = 1;
            else
                sign = -1;

            float[,] Rotate =
            {
                { 1, 0, 0, 0},
                { 0, (float)(Math.Cos(angle)), sign * (float)(Math.Sin(angle)), 0},
                { 0, -sign * (float)(Math.Sin(angle)), (float)(Math.Cos(angle)), 0},
                { 0, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Rotate);
            DrawLetterH();
        }

        
        //Метод вращает букву вдоль оси Y в обе стороны
        private void RotateY_Click(object sender, EventArgs e, string way)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            float angle = (float)(toRotate * Math.PI / 180); // Перевод в радианы

            int sign;
            if (way == "right")
                sign = 1;
            else
                sign = -1;

            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), 0, sign * ((float)(Math.Sin(angle))), 0},
                { 0, 1, 0, 0},
                { -sign * ((float)(Math.Sin(angle))), 0, ((float)(Math.Cos(angle))), 0},
                { 0, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Rotate);
            DrawLetterH();
        }

        
        //Метод вращает букву вдоль оси Z в обе стороны
        private void RotateZ_Click(object sender, EventArgs e, string way)
        {
            int toRotate = Convert.ToInt32(RotateTextBox.Text);
            float angle = (float)(toRotate * Math.PI / 180); // Перевод в радианы

            int sign;
            if (way == "right")
                sign = 1;
            else
                sign = -1;

            float[,] Rotate =
            {
                { ((float)(Math.Cos(angle))), -sign * ((float)(Math.Sin(angle))), 0, 0},
                { sign * ((float)(Math.Sin(angle))), ((float)(Math.Cos(angle))), 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Rotate);
            DrawLetterH();

        }

        
        //Метод отражающий букву относительно плоскостей XY, XZ, YZ
        private void Reflection(object sender, EventArgs e, string plane)
        {
            int X = 1, Y = 1, Z = 1;
            if (plane == "YZ")
                X = -1;
            else if (plane == "XZ")
                Y = -1;
            else
                Z = -1;

            float[,] Mirror =
            {
                { X * 1, 0, 0, 0},
                { 0, Y * 1, 0, 0},
                { 0, 0, Z * 1, 0},
                { 0, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, Mirror);
            DrawLetterH();
        }

        
        //Метод для изменения размеров буквы
        private void Scaling_Click(object sender, EventArgs e, bool sign)
        {
            float PlusOrMinus;
            if (sign)
                PlusOrMinus = 2.0f;
            else
                PlusOrMinus = 0.5f;

            float[,] scaling =
            {
                { PlusOrMinus*1f, 0, 0, 0},
                { 0, PlusOrMinus*1f, 0, 0},
                { 0, 0, PlusOrMinus*1f, 0},
                { 0, 0, 0, 1}
            };
            LetterH = MultiplyMatrices(LetterH, scaling);
            DrawLetterH();
        }

        
        //Метод для обработки нажатия на кнопку ButtonPrintLine 
        private void ButtonPrintLine_Click(object sender, EventArgs e)
        {
            // Получаем координаты из текстовых полей
            if (float.TryParse(CoordinateX.Text, out float x1) &&
                float.TryParse(CoordinateY.Text, out float y1) &&
                float.TryParse(CoordinateZ.Text, out float z1) &&
                float.TryParse(CoordinateX1.Text, out float x2) &&
                float.TryParse(CoordinateY1.Text, out float y2) &&
                float.TryParse(CoordinateZ1.Text, out float z2))
            {
                // Проверяем, что точки не совпадают
                if (x1 != x2 || y1 != y2 || z1 != z2)
                {
                    DrawLineBetweenPoints(previousX, previousY, previousZ, previousX1, previousY1, previousZ1, Pens.White);
                    DrawLineBetweenPoints(x1, y1, z1, x2, y2, z2, Pens.Blue);
                    previousX = x1;
                    previousX1 = x2;
                    previousY = y1;
                    previousY1 = y2;
                    previousZ = z1;
                    previousZ1 = z2;
                }
                else
                {
                    MessageBox.Show("Координаты двух точек не должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные координаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Метод отображающий прямую между двумя точками по заданным координатам
        private void DrawLineBetweenPoints(float x1, float y1, float z1, float x2, float y2, float z2, Pen color)
        {
            graphics = CreateGraphics();
            float[,] point1 = { { x1, y1, z1, 1 } };
            float[,] point2 = { { x2, y2, z2, 1 } };

            point1 = MultiplyMatrices(point1, proection);
            point2 = MultiplyMatrices(point2, proection);

            // Рисуем линию между преобразованными точками
            graphics.DrawLine(color, point1[0, 0], point1[0, 1], point2[0, 0], point2[0, 1]);

        }

        
        //Метод для обработки нажатия на кнопку ButtonPrintLine
        private void ButtonDeleteLine_Click(object sender, EventArgs e)
        {
            DrawLineBetweenPoints(previousX, previousY, previousZ, previousX1, previousY1, previousZ1, Pens.White);
        }

        
        //Метода делающий одно вращение на 360 градусов относительно заданной прямой в любую сторону

        private void Rotate_Click(object sender, EventArgs e, string direction)
        {
            rotationTimer = new Timer();
            rotationTimer.Interval = 70; // Интервал в миллисекундах

            //Определение направления для вращения
            float sign;

            //Вращаем либо по часовой либо против
            if (direction.ToLower() == "forward")
                sign = 1f;
            else
                sign = -1f;

            /* Вычисляется шаг угла вращения на каждый тик таймера
            rotationStep задает на сколько градусов поворачиваем объект за один тик */
            float angleStep = sign * rotationStep; 

            //Обработчик выполняет один тик вращения
            rotationTimer.Tick += new EventHandler((o, ev) =>
            {
                float angle = (float)(angleStep * Math.PI / 180); // Перевод в радианы

                //Определяются координаты начала и конца оси вращения на основе точек
                float x1 = previousX;
                float y1 = previousY;
                float z1 = previousZ;
                float x2 = previousX1;
                float y2 = previousY1;
                float z2 = previousZ1;

                // Определяем вектор направления прямой
                float[] directionVector = { x2 - x1, y2 - y1, z2 - z1 };

                //Если вектор вращения имеет ненулевую длину, он нормализуется, чтобы его длина стала равной 1
                float length = (float)Math.Sqrt(directionVector[0] * directionVector[0] +
                                                directionVector[1] * directionVector[1] +
                                                directionVector[2] * directionVector[2]);

                // Проверка на нулевой вектор
                if (length == 0) return; 

                directionVector[0] /= length;
                directionVector[1] /= length;
                directionVector[2] /= length;

                // Создаем матрицу вращения относительно произвольной оси
                float u = directionVector[0];
                float v = directionVector[1];
                float w = directionVector[2];

                float[,] rotationMatrix =
                {
                    // Вращение по X
                    { (float)(Math.Cos(angle) + u * u * (1 - Math.Cos(angle))),         
                      (float)(u * v * (1 - Math.Cos(angle)) - w * Math.Sin(angle)),     
                      (float)(u * w * (1 - Math.Cos(angle)) + v * Math.Sin(angle)), 0   
                    },

                    // Вращение по Y
                    { (float)(v * u * (1 - Math.Cos(angle)) + w * Math.Sin(angle)),     
                      (float)(Math.Cos(angle) + v * v * (1 - Math.Cos(angle))),         
                      (float)(v * w * (1 - Math.Cos(angle)) - u * Math.Sin(angle)), 0   
                    },      

                    // Вращение по Z
                    { (float)(w * u * (1 - Math.Cos(angle)) - v * Math.Sin(angle)),     
                      (float)(w * v * (1 - Math.Cos(angle)) + u * Math.Sin(angle)),     
                      (float)(Math.Cos(angle) + w * w * (1 - Math.Cos(angle))), 0       
                    },

                    { 0, 0, 0, 1 }
                };

                // Применяем матрицу вращения к букве "H", eмножаем матрицу буквы на матрицу вращения
                LetterH = MultiplyMatrices(LetterH, rotationMatrix);

                //Перерисовываем букву и линии
                DrawLetterH();
                DrawLineBetweenPoints(previousX, previousY, previousZ, previousX1, previousY1, previousZ1, Pens.Blue);
                rotationCount++;

                //Отслеживаем количество выполненных вращений
                if (rotationCount >= totalRotations)
                {
                    rotationTimer.Stop();
                    rotationCount = 0;
                    return;
                }
            });

            rotationTimer.Start();
        }
    }
}
