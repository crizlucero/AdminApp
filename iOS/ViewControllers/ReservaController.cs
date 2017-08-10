using Foundation;
using System;
using UIKit;
using TelerikUI;
using System.Collections.Generic;
using WorklabsMx.iOS.ViewElements;

namespace WorklabsMx.iOS
{
    public partial class ReservaController : UIViewController
    {
        readonly UIScrollView eventView;
        public ReservaController(IntPtr handle) : base(handle)
        {
            eventView = new HorarioEventos();
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
            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Salas", UIBarButtonItemStyle.Plain, (sender, e) =>
            {

            }), true);
            TKCalendar calendarView = new TKCalendar(this.View.Bounds)
            {
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight
            };
            View.AddSubview(calendarView);
            calendarDelegate = new CalendarDelegate(eventView);

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

            calendarView.MinDate = NSDate.Now;
            calendarView.MaxDate = TKCalendar.DateWithYear(DateTime.Now.Year, DateTime.Now.Month, new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1).Day, calendar);
            calendarView.Delegate = calendarDelegate;
            calendarView.DataSource = new CalendarDataSource(this);
            calendarView.NavigateToDate(NSDate.Now, true);
            calendarView.ReloadData();
            eventView.ContentSize = new CoreGraphics.CGSize(UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height / 2);
            Add(eventView);
        }
    }
    class CalendarDataSource : TKCalendarDataSource
    {
        ReservaController main;
        public List<TKCalendarEvent> events;
        public CalendarDataSource(ReservaController main)
        {
            this.main = main;
            events = main.events;
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
        readonly UIScrollView scrollView;
        public CalendarDelegate(UIScrollView scrollView)
        {
            this.scrollView = scrollView;
        }
        public override void DidSelectDate(TKCalendar calendar, NSDate date)
        {
            scrollView.Hidden = false;

        }
    }
}
