using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }


    public override string ToString()
    {
        return $"{Name} - \u20A9{Price:#,###}";
    }

    public virtual string GetDescription()
    {
        return "취급에 주의하세요";
    }
}


public class Electronics : Product
{
    public int Warranty { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} (보증: {Warranty}개월)";
    }

    public override string GetDescription()
    {
        return "전자기기입니다. 취급에 주의하세요.";
    }
}

public class Clothing : Product
{
    public string Size { get; set; }


    public override string ToString()
    {
        return $"{base.ToString()} (사이즈: {Size})";
    }

    public override string GetDescription()
    {
        return "의류입니다. 세탁 방법을 확인하세요.";
    }
}

public class Food : Product
{
    public string ExpirationDate { get; set; }


    public override string ToString()
    {
        return $"{base.ToString()} (유통기한: {ExpirationDate})";
    }

    public override string GetDescription()
    {
        return "식품입니다. 냉장 보관하세요.";
    }
}