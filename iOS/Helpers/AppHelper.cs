using System;
using EventKit;

namespace WorklabsMx.iOS.Helpers
{
    public class AppHelper
    {
        public static AppHelper Current
        {
            get { return current; }
        }
        private static AppHelper current;

        /// <summary>
        /// The EKEventStore is intended to be long-lived. It's expensive to new it up
        /// and can be thought of as a database, so we create a single instance of it
        /// and reuse it throughout the app
        /// </summary>
        public EKEventStore EventStore
        {
            get { return eventStore; }
        }
        protected EKEventStore eventStore;

        static AppHelper()
        {
            current = new AppHelper();
        }
        protected AppHelper()
        {
            eventStore = new EKEventStore();
        }
    }
}
