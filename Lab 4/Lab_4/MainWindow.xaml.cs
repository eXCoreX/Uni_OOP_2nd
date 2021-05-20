using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Lab_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly EventWaitHandle _ewh = new(false, EventResetMode.ManualReset);
        private CancellationTokenSource _cts = new();

        // Save timer to not get it garbage collected
        private readonly Timer _frameTimer;
        public MainWindow()
        {
            InitializeComponent();
            _frameTimer = new Timer(FrameTick, null, new TimeSpan(0), new TimeSpan(0, 0, 0, 0, 20));
        }

        private void FrameTick(object state)
        {
            _ewh.Set();
            _ewh.Reset();
        }

        private readonly HashSet<object> _started = new();

        private void Figure_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is not Shape shape)
            {
                return;
            }
            if (_started.Contains(shape))
            {
                return;
            }

            _started.Add(shape);
            Task.Run(() =>
            {
                var ct = _cts.Token;
                var curr = shape.Dispatcher.Invoke(() => Canvas.GetLeft(shape));
                if (double.IsNaN(curr))
                {
                    curr = 0;
                }
                while (curr < 600)
                {
                    _ewh.WaitOne();
                    curr += 2;
                    if (ct.IsCancellationRequested)
                    {
                        return;
                    }

                    var curr1 = curr;
                    shape.Dispatcher.Invoke(() => Canvas.SetLeft(shape, curr1));
                }
            }, _cts.Token);
        }

        private async void ResetButton_OnClick(object sender, RoutedEventArgs e)
        {
            _cts.Cancel();
            _cts = new CancellationTokenSource();
            await Task.Delay(new TimeSpan(0, 0, 0, 0, 50));
            foreach (UIElement child in MainCanvas.Children)
            {
                if (child is Shape s)
                {
                    Canvas.SetLeft(s, 0);
                }
            }
            _started.Clear();
        }
    }
}
