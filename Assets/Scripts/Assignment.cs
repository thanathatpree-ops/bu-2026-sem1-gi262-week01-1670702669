using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         As01_CheckNumberSign();
         As02_GetDayName();
         As03_ValidatePassword();
         As04_GetGrade();
         As05_IsLeapYear();
         As06_Calculate();
         As07_GetSeason();
         As08_PurchasingSystemExample();
         As09_RockPaperScissorsExample();
         As10_CalculateWeaponDamage();
         As11_DeterminePlayerRank();
    }

    // ข้อ 1
    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    // ข้อ 2
    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
            default:
                Debug.Log("Invalid day");
                break;
        }
    }

    // ข้อ 3
    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // ข้อ 4
    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    // ข้อ 5
    public int as05Year;
    public void As05_IsLeapYear()
    {
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // ข้อ 6
    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        double result = 0;
        switch (as06Op)
        {
            case '+':
                result = as06Num1 + as06Num2;
                break;
            case '-':
                result = as06Num1 - as06Num2;
                break;
            case '*':
                result = as06Num1 * as06Num2;
                break;
            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Error: Cannot divide by zero.");
                    return;
                }
                result = as06Num1 / as06Num2;
                break;
            default:
                Debug.Log("Invalid operator. Please use +, -, *, or /.");
                return;
        }

        Debug.Log($"Result: {result}");
    }

    // ข้อ 7
    public int as07Month;
    public void As07_GetSeason()
    {
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2)
            {
                Debug.Log("It's Winter.");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("It's Spring.");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("It's Summer.");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("It's Fall.");
            }
        }
        else
        {
            Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
        }
    }

    // ข้อ 8
    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log("สินค้าหมด");
        }
        else
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");
                if (as08Payment > as08Price)
                {
                    Debug.Log($"คุณได้รับเงินทอน {as08Payment - as08Price} บาท");
                }
            }
            else
            {
                Debug.Log("คุณมีเงินไม่พอ");
            }
        }
    }

    // ข้อ 9
    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 0 || as09UserChoice > 2)
        {
            Debug.Log("กรุณาเลือกเป็นตัวเลขที่ถูกต้อง");
        }
        else
        {
            if (as09UserChoice == as09ComputerChoice)
            {
                Debug.Log("เสมอ");
            }
            else if ((as09UserChoice == 0 && as09ComputerChoice == 2) ||
                     (as09UserChoice == 1 && as09ComputerChoice == 0) ||
                     (as09UserChoice == 2 && as09ComputerChoice == 1))
            {
                Debug.Log("คุณชนะ!");
            }
            else
            {
                Debug.Log("คุณแพ้!");
            }
        }
    }

    // ข้อ 10
    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        double multiplier = 1.0;
        switch (as10WeaponType?.ToLower())
        {
            case "sword":
                multiplier = 1.3;
                break;
            case "axe":
                multiplier = 1.4;
                break;
            case "bow":
                multiplier = 1.2;
                break;
            case "staff":
                multiplier = 1.5;
                break;
            case "dagger":
                multiplier = 1.1;
                break;
            default:
                multiplier = 1.0;
                break;
        }

        int totalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log(totalDamage.ToString());
    }

    // ข้อ 11
    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        if (as11Score < 0 || as11CompletionTime < 0)
        {
            Debug.Log("Invalid score or time");
            return;
        }

        string rank;
        int baseCoins;
        if (as11Score >= 8000)
        {
            rank = "Gold";
            baseCoins = 100;
        }
        else if (as11Score >= 6000)
        {
            rank = "Silver";
            baseCoins = 75;
        }
        else if (as11Score >= 4000)
        {
            rank = "Bronze";
            baseCoins = 50;
        }
        else
        {
            rank = "Participation";
            baseCoins = 25;
        }

        int timeBonus;
        if (as11CompletionTime <= 30)
        {
            timeBonus = 25;
        }
        else if (as11CompletionTime <= 60)
        {
            timeBonus = 10;
        }
        else
        {
            timeBonus = 0;
        }

        int totalCoins = baseCoins + timeBonus;
        Debug.Log($"{rank} Rank - {totalCoins} coins earned!");
    }
}
