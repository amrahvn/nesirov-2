
    internal class Car
    {
    private string _model { set; get; }
    private int  _topspeed { set; get; }
    private double _engine { set; get; }
    private double _km { set; get; }
    private int _hp { set; get; }


    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (string.IsNullOrEmpty(value)||value.Length>10)
            {
                Console.WriteLine("Model bos ola bilmez,max model uzunluqu 10 olmalidir");
            }
            else 
            {
                _model = value;
            }
        }

    }
     
    public int Topspeed
    {
        get
        {
            return _topspeed;
        }
        set
        {
            if (value < 10 || value > 1000)
            {
                Console.WriteLine("Topspeed min-10 ve max-1000 ola biler");
            }
            else
            {
                _topspeed = value;
            }
        } 
    }

    public double Engine
    {
        get
        {
            return _engine;
        }
        set
        {
            if (value < 0.3 || value > 10)
            {
                Console.WriteLine("Engine min-0.3 ve max-10 ola biler");
            }
            else
            {
                _engine = value;
            }
        }
    }

    public double Km
    {
        get
        {
            return _km;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Km minumum O olmalidir");
            }
            else
            {
                _km = value;
            }
        }
    }
    public int Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value < 50 || value > 1000)
            {
                Console.WriteLine("Hp minumum 50,maksimum 1000 olmalidir");
            }
            else
            {
                _hp = value;
            }
        }
    }

}

