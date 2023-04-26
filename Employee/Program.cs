using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{

  public class Employee  // create a class for employees
  {
    public string _strEmployeeName;
    public bool _blnGender;
    public DateTime _dtmStartDate; // de datum kan leeg zijn       
    private int _WorkingHours;
    public DateTime? _dtmEndDate;

    public Employee(string aNumber, string aName, bool gender, DateTime startDate, bool partTime) // constructor
    {
      AnEmployeeNumber = aNumber;
      Name = aName;
      Gender = gender;
      AStartDate = startDate;
      PartTime = partTime;
    }

    public string AnEmployeeNumber { get; set; }// automatic proporty

    public string Name // proporty
    {
      get
      {

        if (_strEmployeeName == "") // als de naam niet is ingevuld - geef volgende volgens gender terug
        {
          if (Gender)
          {
            return "Jane Doe";
          }
          else
          {
            return "John Doe";
          }
        }
        return _strEmployeeName;
      }
      set
      {
        _strEmployeeName = value; // anders geef de ingevulde naam terug
      }
    }

    public bool Gender // proporty, kan ook gemaakt worden met automatic proporty
    {
      get
      {
        return _blnGender;
      }
      set
      {
        _blnGender = value;
      }
    }


    public DateTime AStartDate { get; set; } // automatic proporty

    public DateTime EndDate // proporty
    {
      get
      {
        if (_dtmEndDate == null) // als de einddatum leeg is, gebruik start datum
        {
          return AStartDate;
        }
        return _dtmEndDate.Value;
      }
      set
      {
        if (value <= AStartDate) // als einddatum vroeger of gelijk is aan startdatum, wijzig in startdatum
        {
          value = AStartDate;
        }
        _dtmEndDate = value;
      }
    }

    public bool PartTime { get; set; } // automatic proporty


    public int WorkingHoursPerWeek // property, read only (enkel de getter, niet mogelijk om wijzigingen aan te brengen)
    {
      get
      {
        if (PartTime) // wanneer de employee parttime werkt geef volgende terug
        {
          return _WorkingHours = 20 + _WorkingHours;
        }
        else // indien fulltime, geef onderstaande terug
        {
          return _WorkingHours = 40 + _WorkingHours;
        }
      }
    }
  }

  class Program
  {
    static void Main()
    {
      Employee els = new Employee("21275534", "els", true, new DateTime(2005, 06, 29), true); // bij creatie nieuw persoon en door constructor worden er al paraters meegegeven
      Employee dirk = new Employee("123456", "dirk", false, new DateTime(2002, 04, 01), false);

      // hieronder voorbereiden in commentaar om te testen

      //els.Name = ""; // leeg veld zal Jane Doe teruggeven op basis van gender
      //els.Gender = false; // wijziging gender bij lege naam geef John terug
      //els.AStartDate = new DateTime(1980, 12, 29);  // vroegere startdatum met latere einddatum         
      //els.PartTime = false;
      //els.EndDate = new DateTime(); // lege einddatum geeft startdatum terug

      els.EndDate = new DateTime(1990, 12, 29); // eind voor start zal start terug geven            

      // dirk.AnEmployeeNumber = "45235425"; // nummer wijzigen
      // dirk.Name = "Dirk Motard"; // naam aanpassen
      // dirk.AStartDate = new DateTime(2022, 02, 4); // start datum aanpassen           

      dirk.EndDate = new DateTime(2000, 04, 01); // eind datum gelijk aan start, zal start terug geven           

      Console.WriteLine(els.AnEmployeeNumber);
      Console.WriteLine(els.Name); // geen naam ingevuld  gender female = jane doe
      Console.WriteLine(els.Gender);
      Console.WriteLine(els.AStartDate);
      Console.WriteLine(els.EndDate); // end date is leeg, neemt start datum
      Console.WriteLine(els.PartTime);
      Console.WriteLine(els.WorkingHoursPerWeek); // werkt niet PartTime, neemt 40 u

      Console.WriteLine();
      Console.WriteLine(dirk.AnEmployeeNumber);
      Console.WriteLine(dirk.Name);
      Console.WriteLine(dirk.Gender);
      Console.WriteLine(dirk.AStartDate);
      Console.WriteLine(dirk.EndDate);
      Console.WriteLine(dirk.PartTime);
      Console.WriteLine(dirk.WorkingHoursPerWeek); 
      Console.WriteLine(dirk.WorkingHoursPerWeek); // VVDW
      Console.WriteLine(dirk.WorkingHoursPerWeek); // VVDW
      Console.WriteLine(dirk.WorkingHoursPerWeek); // VVDW

      Console.ReadLine();

    }
  }
}
