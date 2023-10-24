using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;

namespace FlexibleAutomationTool.BL.Services
{
    internal class TimerBookService
    {
        private Timer _timer;
        private IRepository<Book> _books;
        
        public TimerBookService(IRepository<Book> books, int dueTime, int duePeriod)
        {
            _timer = new Timer(DownloadBookCallBack, null, dueTime, duePeriod);
            _books = books;
        }

        public void Start()
        {
            //
        }

        public void Stop()
        {
            //
        }

        private void DownloadBookCallBack(object state)
        {
            //downloadToService
        }

    }
}
