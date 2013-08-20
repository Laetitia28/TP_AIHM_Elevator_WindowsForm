using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;


public class ControlLift : Control
{
    public double nbFloor = 0;
    public int translate = 0;
    int width = 10;
    int height = 10;
    public List<double> list_call = new List<double>();

    public ControlLift(double nbFloor, int width, int height)
    {
        this.width = width;
        this.height = height;
        this.nbFloor = nbFloor;
        this.Paint += new PaintEventHandler(ControlLift_Paint);


    }

    public double getFloor() {
        return this.nbFloor;

    }
    public void setFloor(double Floor) {
        this.nbFloor = Floor;

    }
    public double getTranslate()
    {
        return this.translate;

    }
    public void setTranslate(int  translate)
    {
        this.translate = translate;

    }
    public void ControlLift_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {

        PaintLift(e.Graphics);
            
    }
    //Cabine
    public void PaintLift(Graphics g){
        Pen pen = new Pen(Color.Black, 1);
        Brush brush = new SolidBrush(Color.Blue);
        Brush brush1 = new SolidBrush(Color.Red);
        g.FillRectangle(brush, 0 - translate , (int)(-nbFloor)+208/*cest le y*/ , 48, 97);
        g.FillRectangle(brush1, 50 + translate, (int)(-nbFloor) + 208/*cest le y*/ , 48, 97);
      
      
    }
}
