using System;
using System.Runtime.ConstrainedExecution;

public class Test
{
	private int Mid;

	public int MyMid
	{
		get
		{
			return Mid;
		}
		set
		{
			if (value < 0 || value > 100)  // ||是或
			{
				Mid = 0;
			}
			else
			{
                Mid = value;
            }
        }
	}

	public int Price
	{
		get
		{
			return MyFinal;
		}
		set
		{
			if (value > 0 && value < 100)
			{
				Final = value;
			}
			else
			{
                Final = 0;
            }
;
		}
	}





}
