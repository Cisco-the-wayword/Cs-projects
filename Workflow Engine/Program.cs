using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new UploadActivity());
            workflow.AddActivity(new VideoEncodingActivity());
            workflow.AddActivity(new EmailNotificationActivity());
            workflow.AddActivity(new ChangeStatusActivity());

            var engine = new WorkflowEngine();
            engine.Run(workflow);

            Console.ReadLine();
        }
    }

    public interface IActivity
    {
        void Execute();
    }

    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }

    public class Workflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }

    public class UploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage...");
        }
    }

    public class VideoEncodingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party video encoding service...");
        }
    }

    public class EmailNotificationActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email notification to video owner...");
        }
    }

    public class ChangeStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing status of video record in the database to Processing...");
        }
    }
}
