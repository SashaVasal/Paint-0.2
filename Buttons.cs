using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    // DropDownMenu
    // 

    class Buttons
    {
        readonly Button LineButton = new Button()
        {
            Dock = System.Windows.Forms.DockStyle.None,
            FlatStyle = System.Windows.Forms.FlatStyle.Flat,
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            ForeColor = System.Drawing.SystemColors.ButtonHighlight,
            Margin = new System.Windows.Forms.Padding(0),
            Name = "DropDownMenu",
            Size = new System.Drawing.Size(200, 62),
            TabIndex = 6,
            Text = "Line",
            UseVisualStyleBackColor = true
        };
        readonly Button BrushButton = new Button()
        {
            Dock = System.Windows.Forms.DockStyle.None,
            FlatStyle = System.Windows.Forms.FlatStyle.Flat,
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            ForeColor = System.Drawing.SystemColors.ButtonHighlight,
            Margin = new System.Windows.Forms.Padding(0),
            Name = "BrushButton",
            Size = new System.Drawing.Size(200, 62),
            TabIndex = 11,
            Text = "Brush",
            UseVisualStyleBackColor = true

        };
        readonly CheckBox DashBox = new CheckBox()
        {
            Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right))),
            AutoSize = true,
            Name = "DashBox",
            Size = new System.Drawing.Size(15, 14),
            TabIndex = 8,
            UseVisualStyleBackColor = true
        };
        readonly CheckBox HatchBox = new CheckBox()
        {
            AutoSize = true,
            Name = "HatchBox",
            Size = new System.Drawing.Size(15, 14),
            TabIndex = 12,
            UseVisualStyleBackColor = true
        };

        public ColorDialog ColorDialog1 = new ColorDialog();
        public Parametr tool = new Parametr();
        readonly Button Color_Line = new Button()
        {
            Height = 40,
            Width = 120,
            BackColor = Color.Red,
            ForeColor = Color.Blue,
            Text = "Color",
            Name = "DynamicButton",
            Font = new Font("Georgia", 16)
        };
        readonly NumericUpDown _numericUp = new NumericUpDown()
        {
            Maximum = 360,
            Minimum = 0,
            Name = "_numericUp",
            Height = 40,
            Width = 120,
            TabIndex = 5
        };
        readonly NumericUpDown _numericDown = new NumericUpDown()
        {
            Maximum = 360,
            Minimum = 0,
            Name = "_numericDown",
            Height = 40,
            Width = 120,
            TabIndex = 5
        };
        readonly TrackBar Width_Bar = new TrackBar()
        {
            Minimum = 1,
            Name = "Width_Bar",
            Height = 40,
            Width = 120,
            TabIndex = 5,
            TickFrequency = 2,
        };
        public Buttons(){
            Width_Bar.Scroll += new EventHandler(Width_Bar_Click);
            LineButton.Click += new EventHandler(LineButtonClick);
            Color_Line.Click += new EventHandler(ChangeColor_Click);
            BrushButton.Click += new EventHandler(BrushButtonClick);
            HatchBox.Click += new EventHandler(HatchBoxClick);
            _numericDown.ValueChanged += new EventHandler(NumericDown_click);
            _numericDown.Value = 0;
            _numericUp.Value = 0;
            _numericUp.ValueChanged += new EventHandler(NumericUp_click);
        }
        
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tool.color = ColorDialog1.Color;
        }
        private void Width_Bar_Click(object sender, EventArgs e)
        {
            tool.width = _Width_Bar.Value;
        }
        private void NumericUp_click(object sender, EventArgs e)
        {
            tool.sweepAngle = Convert.ToInt32(_numericUp.Value);
        }
        private void NumericDown_click(object sender, EventArgs e)
        {
            tool.startAngle = Convert.ToInt32(_numericDown.Value);
        }
        private void HatchBoxClick(object sender, EventArgs e)
        {
            tool.hatchBrush = HatchBox.Checked;
        }
        private void BrushButtonClick(object sender, EventArgs e)
        {
            tool.brush = true;
        }
        private void LineButtonClick(object sender, EventArgs e)
        {
            tool.brush = false;
        }
        private void DashBoxClick(object sender, EventArgs e)
        {
            tool.dashPattern = DashBox.Checked;
        }
        public List<Control> buttons = new List<Control>();       
        public Panel panel1 = new Panel();
        Point point = new Point(15, 278);
        public TrackBar _Width_Bar => Width_Bar;

        public void ChooseColor()
        {           
            Color_Line.Location = point;
            point.Y += Color_Line.Size.Height + 10;
            buttons.Add(Color_Line);
           
        }
        public void WidthBar()
        {
            _Width_Bar.Location = point;
            _Width_Bar.Value = Convert.ToInt32(tool.width);
            _Width_Bar.Scroll += new EventHandler(Width_Bar_Click);
            point.Y += _Width_Bar.Size.Height + 10;
            buttons.Add(_Width_Bar);
        }     
        public void Button_L()
        {
            
            LineButton.Location = point;
            Point new_point = new Point();
            new_point = point;
            new_point.X += 150;     
            new_point.Y += 25;
            DashBox.Click += new EventHandler(DashBoxClick);
            DashBox.Location = new_point;
            point.Y += LineButton.Size.Height + 10;
            buttons.Add(DashBox);
            buttons.Add(LineButton);
           
        }
        public void Button_R()
        {
            BrushButton.Location = point;
            _ = new Point();
            Point new_point = point;
            new_point.X += 150;
            new_point.Y += 25;
            point.Y += BrushButton.Size.Height + 10;
            HatchBox.Location = new_point;         
            buttons.Add(HatchBox);
            buttons.Add(BrushButton);          
        }    
        public void NumericUp()
        {                    
            _numericUp.Location = point;
            point.Y += _numericUp.Size.Height + 10;
            buttons.Add(_numericUp);
        }
        public void NumericDown()
        {
            _numericDown.Location = point;
            point.Y += _numericDown.Size.Height + 10;   
            buttons.Add(_numericDown);
        }
        public void PenClick()
        {
            buttons.Clear();         
            point = new Point(15, 278);
            ChooseColor();
            WidthBar();
            Button_L();
        }
        public void SquareClick()
        {
            buttons.Clear();           
            point = new Point(15, 278);
            ChooseColor();
            WidthBar();           
            Button_L();
            Button_R();
        }
        public void PieClick()
        {
            buttons.Clear();            
            point = new Point(15, 278);
            ChooseColor();
            WidthBar();
            NumericUp();
            NumericDown();
            Button_L();
            Button_R();
        }
        public void LineClick()
        {
            buttons.Clear();          
            point = new Point(15, 278);
            ChooseColor();
            WidthBar();
            Button_L();
        }
        public void EllipseClick()
        {
            buttons.Clear();
            point = new Point(15, 278);
            ChooseColor();
            WidthBar();
            Button_L();
            Button_R();
        }
    }
}
