using Foundation;
using System;
using UIKit;
using CoreGraphics;
using TelerikUI;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class ReservaController : UIViewController
    {

        public ReservaController(IntPtr handle) : base(handle)
        {
        }
        CalendarDelegate calendarDelegate;
        public List<TKCalendarEvent> events;

        public TKCalendar CalendarView
        {
            get;
            set;
        }

        public TKCalendarEventProtocol[] EventsForDate
        {
            get;
            set;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // >> getting-started-calendar-cs
            TKCalendar calendarView = new TKCalendar(this.View.Bounds);
            calendarView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
            this.View.AddSubview(calendarView);
            // << getting-started-calendar-cs
            calendarDelegate = new CalendarDelegate();

            events = new List<TKCalendarEvent>();
            NSCalendar calendar = new NSCalendar(NSCalendarType.Gregorian);
            NSDate date = NSDate.Now;

            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                NSDateComponents components = calendar.Components(NSCalendarUnit.Day | NSCalendarUnit.Month | NSCalendarUnit.Year, date);
                components.Day = r.Next() % 20;

                TKCalendarEvent ev = new TKCalendarEvent
                {
                    Title = "Test",
                    StartDate = calendar.DateFromComponents(components),
                    EndDate = calendar.DateFromComponents(components),
                    EventColor = UIColor.Red
                };

                events.Add(ev);
            }

            calendarView.MinDate = TKCalendar.DateWithYear(2017, 7, 1, calendar);
            calendarView.MaxDate = TKCalendar.DateWithYear(2017, 7, 31, calendar);
            calendarView.Delegate = calendarDelegate;
            calendarView.DataSource = new CalendarDataSource(this);
            NSDateComponents newComponents = new NSDateComponents();
            newComponents.Year = 2017;
            newComponents.Month = 7;
            newComponents.Day = 1;
            NSDate newDate = calendarView.Calendar.DateFromComponents(newComponents);
            calendarView.NavigateToDate(newDate, true);

            calendarView.ReloadData();
        }
    }
    class CalendarDataSource : TKCalendarDataSource
    {
        ReservaController main;
        public List<TKCalendarEvent> events;
        public CalendarDataSource(ReservaController main)
        {
            this.main = main;
            this.events = main.events;
        }

        public override TKCalendarEventProtocol[] EventsForDate(TKCalendar calendar, NSDate date)
        {
            NSDateComponents components = calendar.Calendar.Components(NSCalendarUnit.Day | NSCalendarUnit.Month | NSCalendarUnit.Year, date);
            components.Hour = 23;
            components.Minute = 59;
            components.Second = 59;
            NSDate endDate = calendar.Calendar.DateFromComponents(components);
            List<TKCalendarEventProtocol> filteredEvents = new List<TKCalendarEventProtocol>();
            for (int i = 0; i < this.events.Count; i++)
            {
                if (events[i].StartDate.SecondsSinceReferenceDate <= date.SecondsSinceReferenceDate &&
                    events[i].EndDate.SecondsSinceReferenceDate >= date.SecondsSinceReferenceDate)
                {
                    filteredEvents.Add(events[i]);
                }
            }
            return filteredEvents.ToArray();
        }

    }

    class CalendarDelegate : TKCalendarDelegate
    {
        public override void DidSelectDate(TKCalendar calendar, NSDate date)
        {
            Console.WriteLine("{0}", date);
        }
    }
}
