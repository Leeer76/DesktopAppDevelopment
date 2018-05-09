/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author el51909
 */
public class triangle {
        //private variables
    private double dblSide1 = 0;
    private double dblSide2 = 0;
    private double dblSide3 = 0;

    //constructor
    public triangle(double S1, double S2, double S3)
    {
        setSide1(S1);
        setSide2(S2);
        setSide3(S3);
    }

    //getters
    public double getSide1()
    {
        return dblSide1;
    }
    public double getSide2()
    {
        return dblSide2;
    }
    public double getSide3()
    {
        return dblSide3;
    }

    //setters
    public void setSide1(double dblSide)
    {
        this.dblSide1 = dblSide;
    }
    public void setSide2(double dblSide)
    {
        this.dblSide2 = dblSide;
    }
    public void setSide3(double dblSide)
    {
        this.dblSide3 = dblSide;
    }

    //other methods
    public boolean isEquilateral()
    {
        //all 3 sides must be the same length
        if (getSide1() == getSide2() &&
                getSide2() == getSide3() &&
                getSide3() == getSide1())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public boolean isIsosceles()
    {
        //two sides must be the same length
        if (getSide1() == getSide2() ||
                getSide2() == getSide3() ||
                getSide3() == getSide1())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public boolean isRight()
    {
        //pythagorean theorm
        if (Math.pow(getSide1(),2) + Math.pow(getSide2(), 2) == Math.pow(getSide3(),2) ||
                Math.pow(getSide2(),2) + Math.pow(getSide3(), 2) == Math.pow(getSide1(),2) ||
                Math.pow(getSide3(),2) + Math.pow(getSide1(), 2) == Math.pow(getSide2(),2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double getArea()
    {
        //first get the semiperimeter
        double s = (getSide1() + getSide2() + getSide3()) / 2;

        //then calculate the area
        return Math.sqrt(s * (s - getSide1()) * (s - getSide2()) * (s - getSide3()));
    }



    
}
