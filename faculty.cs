using System;

class Faculty : Person {
//Properties
public string Id { get; set; }
public string Title { get; set; }
public string Employer { get; set; }
public decimal YearlySalary { get; set; }
public bool Tenured { get; set; }
public virtual DateTime DateOfEmployment { get; set; }

//Constructors
public Faculty() : base() {
  Title = "Instructor";
}
public Faculty(string fname, string lname) : base(fname, lname) {
  Title = "Instructor";
}

//Methods
public void GrantTenure() {
  int experience = DateTime.Today.Year - DateOfEmployment.Year;
          if (experience >= 5) {
            Console.WriteLine("Tenured");
          Tenured = true;
          } else
          Tenured = false;
            Console.WriteLine("Not Tenured");
        }
        
        public void Promote() {
  int experience = DateTime.Today.Year - DateOfEmployment.Year;
  if ((Title == "Instructor") && (experience >= 2)) {
    Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
  }
if ((Title == "Assistant Professor") && (experience >= 5)) {
    Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
  }
  if ((Title == "Associate Professor") && (experience >= 10)) {
    Title = "Professor";
      Console.WriteLine("Faculty promoted to Professor rank");
  }
  if (Title == "Professor") {
      Console.WriteLine("No more promotion possible");
  }  
}

/*
Additional message should display the title, college and year of employment
Example "I work as Assistant Professor at Tri-C since 1997"
*/
public override void Intro() {
    base.Intro();
    Console.WriteLine("I work as " + Title + " at "+ Employer + " since " + DateOfEmployment.Year);
  }
}