using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
         NumericUpDown HatchStyle = new NumericUpDown()
        {
            Maximum = 3,
            Minimum = 0,
            Name = "_numericUp",
            Height = 40,
            Width = 40,
            TabIndex = 5
        };
        public ColorDialog FillColorDialog = new ColorDialog();
        public ColorDialog LineColorDialog = new ColorDialog();
        public Parametr tool = new Parametr();
        readonly Button Color_Line = new Button()
        {
            Height = 40,
            Width = 120,
            BackColor = Color.Red,
            ForeColor = Color.Blue,
            Text = "Color Line",
            Name = "DynamicButton",
            Font = new Font("Georgia", 16)
        };
        readonly Button Color_Fill = new Button()
        {
            Height = 40,
            Width = 120,
            BackColor = Color.Red,
            ForeColor = Color.Blue,
            Text = "Color Fill",
            Name = "DynamicButton",
            Font = new Font("Georgia", 16)
        };
        
        readonly Button Color_Hatch = new Button()
        {
            Height = 40,
            Width = 120,
            BackColor = Color.Red,
            ForeColor = Color.Blue,
            Text = "Hatch Color",
            Name = "DynamicButton",
            Font = new Font("Georgia", 16)
        };
        readonly Button Animate_Button = new Button()
        {
            Dock = System.Windows.Forms.DockStyle.None,
            FlatStyle = System.Windows.Forms.FlatStyle.Flat,
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            ForeColor = System.Drawing.SystemColors.ButtonHighlight,
            Margin = new System.Windows.Forms.Padding(0),
            Name = "Animate",
            Size = new System.Drawing.Size(200, 62),
            TabIndex = 6,
            Text = "Animate",
            UseVisualStyleBackColor = true
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
        readonly NumericUpDown NumericAnimate = new NumericUpDown()
        {
            Maximum = 3,
            Minimum = 0,
            Name = "NumericAnimate",
            Height = 40,
            Width = 40,
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
        public void Animate_Click(object sender, EventArgs e)
        {
            if(!tool.penPicker.animate)
            {
                tool.penPicker.animate = true;
            }
            else
            {
                tool.penPicker.animate = false;
            }
            

        }
        public Buttons(){
            Width_Bar.Scroll += new EventHandler(Width_Bar_Click);
            LineButton.Click += new EventHandler(LineButtonClick);
            Color_Line.Click += new EventHandler(ChangeLineColor_Click);
            Color_Fill.Click += new EventHandler(ChangeFillColor_Click);
            Color_Hatch.Click += new EventHandler(ChangeHatchColor_Click);
            BrushButton.Click += new EventHandler(BrushButtonClick);
            Animate_Button.Click += new EventHandler(Animate_Click);
            //HatchBox.Click += new EventHandler(HatchBoxClick);
            HatchStyle.ValueChanged += new EventHandler(HatchBoxClick);

            NumericAnimate.ValueChanged += new EventHandler(AnimateValue_click);
            _numericDown.ValueChanged += new EventHandler(NumericDown_click);
            _numericDown.Value = 0;
            _numericUp.Value = 0;
            _numericUp.ValueChanged += new EventHandler(NumericUp_click);
        }

        private void ChangeLineColor_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            tool.penPicker.colorLine = LineColorDialog.Color;
        }
        private void ChangeHatchColor_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            tool.penPicker.colorHatch = LineColorDialog.Color;
        }
        private void ChangeFillColor_Click(object sender, EventArgs e)
        {
            if (FillColorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            tool.penPicker.colorFill = FillColorDialog.Color;
        }
        private void Width_Bar_Click(object sender, EventArgs e)
        {
            tool.penPicker.width = _Width_Bar.Value;
        }
        private void AnimateValue_click(object sender, EventArgs e)
        {
            tool.penPicker.animateValue = Convert.ToInt32(NumericAnimate.Value);          
        }
        private void NumericUp_click(object sender, EventArgs e)
        {
            tool.sweepAngle = Convert.ToInt32(_numericUp.Value);
            tool.drawable = new Draw_Pie(tool.penPicker,  tool.startAngle, tool.sweepAngle, tool.history);
        }
        private void NumericDown_click(object sender, EventArgs e)
        {
            tool.startAngle = Convert.ToInt32(_numericDown.Value);
            tool.drawable = new Draw_Pie(tool.penPicker,  tool.startAngle, tool.sweepAngle, tool.history);
        }
        private void HatchBoxClick(object sender, EventArgs e)
        {
            if(HatchStyle.Value == 0)
            {
                tool.penPicker.hatchBool = false;
            }
            else
            {
                tool.penPicker.hatchBool = true;
                tool.penPicker.ChooseHatch = Convert.ToInt32(HatchStyle.Value) - 1;
            }


        }
        private void BrushButtonClick(object sender, EventArgs e)
        {
            tool.penPicker.PickBrush();
        }
        private void LineButtonClick(object sender, EventArgs e)
        {
            tool.penPicker.PickPen();
        }
        private void DashBoxClick(object sender, EventArgs e)
        {
            tool.penPicker.dashBool = DashBox.Checked;
        }
        public List<Control> buttons = new List<Control>();       
        
        Point point = new Point(150, 46);
        public TrackBar _Width_Bar => Width_Bar;
        public void Animation()
        {
           
            Point new_point = point;
            new_point.X += 150;
            new_point.Y += 25;           
            NumericAnimate.Location = new_point;
            Animate_Button.Location = point;
            NumericAnimate.Location = new_point;
            point.Y += Animate_Button.Size.Height + 10;
            buttons.Add(NumericAnimate);
            
            buttons.Add(Animate_Button);
        }
        public void LineColor()
        {           
            Color_Line.Location = point;
            point.Y += Color_Line.Size.Height + 10;
            buttons.Add(Color_Line);       
        }
        public void FillColor()
        {
            Color_Fill.Location = point;
            point.Y += Color_Line.Size.Height + 10;
            buttons.Add(Color_Fill);
        }
        public void HatchColor()
        {
            Color_Hatch.Location = point;
            point.Y += Color_Hatch.Size.Height + 10;
            buttons.Add(Color_Hatch);
        }
        public void WidthBar()
        {
            _Width_Bar.Location = point;
            _Width_Bar.Value = Convert.ToInt32(tool.penPicker.width);
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
            HatchStyle.Location = new_point;         
            buttons.Add(HatchStyle);
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
        void StackFunc()
        {
            buttons.Clear();
            point = new Point(150, 46);
            LineColor();
            WidthBar();
            Button_L();
        }
        public void PenClick()
        {
            StackFunc();
        }
        public void SquareClick()
        {
            StackFunc();
           
            Button_R();
            FillColor();
            Animation();
            HatchColor();
            
        }
        public void PieClick()
        {
            StackFunc();
            FillColor();
            NumericUp();
            NumericDown();
            HatchColor();
        }
        public void LineClick()
        {
            StackFunc();
        }
        public void EllipseClick()
        {
            StackFunc();
            Button_R();
            FillColor();
            HatchColor();
        }
        public void HandClick()
        {
            buttons.Clear();
        }
        public void ZoomClick()
        {
            buttons.Clear();
        }
    }
}
