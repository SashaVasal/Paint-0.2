using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Graph
{
    
    public partial class WindowsForm : Form
    {
        public delegate void Handler();
        
        Parametr tool;
        ToolPicker picker = new ToolPicker();
        double tick = 0;

        readonly Buttons buttons = new Buttons();
        public WindowsForm()
        {
           
            InitializeComponent();
            tool = new Parametr()
            {
               
            };
            picker.parametr = tool;
            tool.viewSize.Height = 1000;
            tool.viewSize.Width = 1000;
            buttons.LineColorDialog = LineColorDialog;
            buttons.FillColorDialog = FillColorDialog;
            buttons.tool = tool;
            canvas.Image = new Bitmap(2000, 2000);
            tool.canvas = canvas;
            tool.history = new History();
            tool.drawable = new Draw_Line(tool.penPicker, tool.history);
            var handlers = new List<Handler>
            {
                () =>
                {
                        picker.PickEllipse(ref tool.drawable);
                        buttons.EllipseClick();
                },
                () =>
                {
                       picker.PickSquare(ref tool.drawable);
                       buttons.SquareClick();
                },
                () =>
                {
                       picker.PickPen(ref tool.drawable);
                       buttons.PenClick();
                },
                () =>
                {
                    picker.PickPie(ref tool.drawable);
                    buttons.PieClick();
                },
                 () =>
                {
                    picker.PickLine(ref tool.drawable);
                    buttons.LineClick();
                },
                 () =>
                {
                    picker.PickZoom(ref tool.drawable);
                    buttons.ZoomClick();
                },
                 () =>
                {
                    picker.PickHand(ref tool.drawable);
                    buttons.HandClick();
                },
            };
            List<Button> ControlsButtons = new List<Button> {
              new Button { Name = "Ellipse",Text = "Ellipse", BackColor = Color.White, TabIndex = 0, Height = 40, Width=100},
              new Button { Name = "Square",Text = "Square", BackColor = Color.White, TabIndex = 1, Height = 40, Width=100},
              new Button { Name = "Pen",Text = "Pen", BackColor = Color.White, TabIndex = 2, Height = 40, Width=100},
              new Button { Name = "Pie",Text = "Pie", BackColor = Color.White, TabIndex = 3, Height = 40, Width=100},
              new Button { Name = "Line",Text = "Line", BackColor = Color.White, TabIndex = 4, Height = 40, Width=100},
              new Button { Name = "Zoom",Text = "Zoom", BackColor = Color.White, TabIndex = 5, Height = 40, Width=100},
              new Button { Name = "Hand",Text = "Hand", BackColor = Color.White, TabIndex = 6, Height = 40, Width=100},
            };
            int X = 0;
           
            foreach (var b in ControlsButtons)
            {              
                b.Location = new Point(25, X+=50);
                b.Click += (sender, EventArgs) => {
                    foreach (Control f in buttons.buttons)
                    {
                        Controls.Remove(f);
                    }

                    handlers[b.TabIndex]();

                    foreach (Control f in buttons.buttons)
                    {
                        Controls.Add(f);
                    }
                };               
                Controls.Add(b);
            };
        
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

           
            if (tool.stateMouse == StateMouse.MouseLeft || tool.stateMouse == StateMouse.MouseRight)
            {             
                tool.drawable.SetOldPoint(tool.MovePoint);               
                tool.drawable.SetMovePoint(e.Location);
                tool.MovePoint = e.Location;
                foreach(Shape s in tool.history.h)
                {
                    s.Draw(false, Graphics.FromImage(canvas.Image));
                }
            }                           
           Refresh();

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            
            tool.StartPoint = e.Location;
            tool.MovePoint = e.Location;
            tool.drawable.SetOldPoint(tool.MovePoint);
            tool.drawable.SetStartPoint(tool.StartPoint);
            tool.drawable.SetMovePoint(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                tool.stateMouse = StateMouse.MouseLeft;
                tool.drawable.SetMouseState(StateMouse.MouseLeft);
            }
            if (e.Button == MouseButtons.Right)
            {
                tool.stateMouse = StateMouse.MouseRight;
                tool.drawable.SetMouseState(StateMouse.MouseRight);
            }

            
           
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool.stateMouse == StateMouse.MouseLeft)
            {
                
                tool.MovePoint = e.Location;
                tool.stateMouse = StateMouse.MouseLeftUp;
                tool.drawable.SetMouseState(StateMouse.MouseLeftUp);
            }

            if (tool.stateMouse == StateMouse.MouseRight)
            {              
                tool.MovePoint = e.Location;
                tool.stateMouse = StateMouse.MouseRightUp;
                tool.drawable.SetMouseState(StateMouse.MouseRightUp);
            }          
            tool.drawable.Draw(true, Graphics.FromImage(canvas.Image));
            tool.drawable.SetMouseState(StateMouse.MouseIdle);
            tool.drawable.penPicker.animate = tool.penPicker.animate;
            
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
           tool.drawable.Draw(true,e.Graphics);
                        
        }

        private void Save_click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PaintCLone files (*.json) | *.json";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>));

                using (var file = new FileStream(@"image.json", FileMode.Create))
                {
                    jsonFormatter.WriteObject(file, tool.history.h);
                }
            
            
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>));
            List<Shape> q = new List<Shape>();
            using (var file = new FileStream(@"image.json", FileMode.OpenOrCreate))
            {
                try
                {
                    q = jsonFormatter.ReadObject(file) as List<Shape>;
                    tool.history.h.AddRange(q);
                    foreach (Shape h in tool.history.h)
                    {
                        h.Draw(false, Graphics.FromImage(canvas.Image));
                    }
                    Update();
                }
                catch
                {
                    MessageBox.Show("Ошибка чтения файла! Возможно, файл поврежден.");
                }
            }


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
          
            Graphics.FromImage(canvas.Image).Clear(Color.White);
            foreach (Shape s in tool.history.h)
            {
                s.Animate();                                            
                s.Draw(false, Graphics.FromImage(canvas.Image));
               
            }
            Refresh();

        }
    }
}

