using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public class History : JsonConverter
    {
        public History()
        {
            
        }
        public List<Shape> h =  new List<Shape>();
        public void AddElement(Shape shape, Point StartPoint, Point MovePoint, Point OldMovePoint, PenPicker penPicker)
        {
            shape.history = null;
            shape.StartPoint = StartPoint;
            shape.MovePoint = MovePoint;
            shape.OldMovePoint = OldMovePoint;
            shape.penPicker = new PenPicker
            {
                width = penPicker.width,
                colorFill = penPicker.colorFill,
                colorLine = penPicker.colorLine,
                brushBool = penPicker.brushBool,
                penBool = penPicker.penBool,
                ChooseHatch = penPicker.ChooseHatch,
                hatchBool = penPicker.hatchBool,
                colorHatch = penPicker.colorHatch,
                dashBool = penPicker.dashBool,
                hatchStyle = penPicker.hatchStyle,
                animate = penPicker.animate,
                animateValue = penPicker.animateValue

            };
            h.Add(shape);
        }
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Shape));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["NameFigure"].Value<string>() == "Pen")
                return jo.ToObject<Draw_Pen>(serializer);
            if (jo["NameFigure"].Value<string>() == "Ellipse")
                return jo.ToObject<Draw_Ellipse>(serializer);
            if (jo["NameFigure"].Value<string>() == "Rectangle")
                return jo.ToObject<Draw_Square>(serializer);
            if (jo["NameFigure"].Value<string>() == "Pie")
                return jo.ToObject<Draw_Pie>(serializer);
            if (jo["NameFigure"].Value<string>() == "Line")
                return jo.ToObject<Draw_Line>(serializer);
            return null;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        
    }
    

}
