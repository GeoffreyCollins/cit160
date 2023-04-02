using System;

class Lecture : Event
{
    public Lecture(string desc) : base("Foundations of the Restoration",
                                        "Lecture on the beginnings of the Restoration of the Church of Jesus Christ of Latter-Day Saints",
                                        "April 03, 2023",
                                        "11:15",
                                        "South 2nd Street East, Rexburg, ID")
    {

    }

    public Lecture(string title, string desc, string date, string time, string address) 
                : base(title, desc, date, time, address)
    {

    }

    public void PresentLecture()
    {
        DisplayEvent();
    }
}