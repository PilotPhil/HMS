using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace pilot.SCADA.Views
{
    /// <summary>
    /// BluePrintView.xaml 的交互逻辑
    /// </summary>
    public partial class BluePrintView : UserControl
    {
        public BluePrintView()
        {
            InitializeComponent();

            //添加事件
            //this.db1.AddHandler(Canvas.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.MouseButtonLeftDown), true);
            //为 将要被 移动的 按钮 添加路由事件，来自canvas的路由事件：鼠标左键按下，处理器为 MouseButtonLeftDown
        }


        #region 画布 移动 缩放
        Matrix mymat = new Matrix(1, 0, 0, 1, 0, 0);//存储当前控件位移和比例
        //MatrixTransform mychange;
        Point startpoint;
        Point currentpoint;
        //double scale = 1;

        private void Layer_bg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startpoint = e.GetPosition((FrameworkElement)(this.Parent));//记录开始位置
            currentpoint.X = mymat.OffsetX;//记录Canvas当前位移
            currentpoint.Y = mymat.OffsetY;

        }
        private void Layer_bg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point currp = e.GetPosition((FrameworkElement)(this.Parent));
                double dx = currp.X - startpoint.X + currentpoint.X;
                double dy = currp.Y - startpoint.Y + currentpoint.Y;//总位移等于当前的位移加上已有的位移
                MatrixChange(dx, dy);//移动控件，并更新总位移
            }
        }
        private void MatrixChange(double dx, double dy, double scale)
        {
            mymat.M11 = scale;
            mymat.M22 = scale;
            mymat.OffsetX = dx;
            mymat.OffsetY = dy;
            this.mainView.RenderTransform = new MatrixTransform(mymat);
        }
        private void MatrixChange(double dx, double dy)
        {
            //             mymat.M11 = scale;
            //             mymat.M22 = scale;
            mymat.OffsetX = dx;
            mymat.OffsetY = dy;
            this.mainView.RenderTransform = new MatrixTransform(mymat);
        }
        private void Layer_bg_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Point p1 = e.GetPosition(this);//得当鼠标相对于控件的坐标

            double dx, dy;
            double scale = mymat.M11;
            if (e.Delta > 0)
            {
                scale += 0.2;
                if (scale > 4)
                {
                    scale = 4;
                    return;
                }

                dx = p1.X * (scale - 0.2) - scale * p1.X + mymat.OffsetX;
                dy = p1.Y * (scale - 0.2) - scale * p1.Y + mymat.OffsetY;//放大本质是 移动和缩放两个步骤 
                                                                         //
                MatrixChange(dx, dy, scale);

            }
            else
            {
                scale -= 0.2;
                if (scale < 0.5)
                {
                    scale = 0.5;
                    return;
                }

                dx = p1.X * (scale + 0.2) - scale * p1.X + mymat.OffsetX;
                dy = p1.Y * (scale + 0.2) - scale * p1.Y + mymat.OffsetY;
                MatrixChange(dx, dy, scale);
            }
        }
        public void ResetPosition(object sender, RoutedEventArgs e)
        {
            MatrixChange(0, 0, 1);
        }

        #endregion


        #region 移动标志
        /// <summary>
        /// 鼠标左键按下
        /// </summary>
        private void MouseButtonLeftDown(object sender, MouseButtonEventArgs e)
        {
            DragButton dragButton = sender as DragButton;

            if (dragButton != null && dragButton.IsDrag == false)//确保：鼠标左键点击对象为一个dragButton，且其是否可拖拽属性为false
            {
                dragButton.ClickPos = e.GetPosition(dragButton);//获取鼠标 点时 在按钮上的位置
                this.Layer_point.Children.Add(dragButton.Rect);//canvas添加 虚框
                dragButton.IsDrag = true;//设置为处于 拖拽状态

                //为dragButton注册 路由事件--->来自canvas的移动事件
                dragButton.AddHandler(Canvas.MouseMoveEvent, new MouseEventHandler(this.Canvas_MouseMove), true);//拖拽 使能
                dragButton.AddHandler(Canvas.MouseLeftButtonUpEvent, new MouseButtonEventHandler(this.CanvasButtonLeftUp), true);//松开鼠标 拖拽 作废false
            }
        }

        /// <summary>
        /// 区域移动事件
        /// </summary>
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            DragButton dragButton = sender as DragButton;
            if (dragButton != null && dragButton.IsDrag == true)//确认 是一个 dragButton 且 能够被拖拽
            {
                Point offsetPoint = e.GetPosition(this.Layer_point);
                double xOffset = offsetPoint.X - dragButton.CurrentPos.X - dragButton.ClickPos.X;
                double yOffset = offsetPoint.Y - dragButton.CurrentPos.Y - dragButton.ClickPos.Y;

                TranslateTransform transform = (TranslateTransform)dragButton.Rect.RenderTransform;//移动的是 虚框
                transform.X += xOffset;
                transform.Y += yOffset;

                dragButton.CurrentPos = new Point(offsetPoint.X - dragButton.ClickPos.X, offsetPoint.Y - dragButton.ClickPos.Y);
            }
        }

        /// <summary>
        /// 区域鼠标左键抬起
        /// </summary>
        private void CanvasButtonLeftUp(object sender, MouseButtonEventArgs e)
        {
            DragButton dragButton = sender as DragButton;
            if (dragButton != null && dragButton.IsDrag)
            {
                Canvas.SetLeft(dragButton, dragButton.CurrentPos.X);
                Canvas.SetTop(dragButton, dragButton.CurrentPos.Y);

                this.Layer_point.Children.Remove(dragButton.Rect);

                dragButton.IsDrag = false;

                //移除事件
                dragButton.RemoveHandler(Canvas.MouseMoveEvent, new MouseEventHandler(this.Canvas_MouseMove));
                dragButton.RemoveHandler(Canvas.MouseLeftButtonUpEvent, new MouseButtonEventHandler(this.CanvasButtonLeftUp));
            }
        }


        #endregion

        private bool CanEdit = false;

        /// <summary>
        /// 编辑 使能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit(object sender, RoutedEventArgs e)
        {
            CanEdit = !CanEdit;

            var bt = new BitmapImage();
            bt.BeginInit();

            if (CanEdit == true)//可移动编辑状态
            {
                bt.UriSource = new Uri("../Assets/img/move.png", UriKind.Relative);
                this.db1.AddHandler(Canvas.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.MouseButtonLeftDown), true);
            }
            else
            {
                bt.UriSource = new Uri("../Assets/img/lock.png", UriKind.Relative);
                this.db1.RemoveHandler(Canvas.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.MouseButtonLeftDown));
            }

            bt.EndInit();
            this.img_edit.Source = bt;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh(object sender, RoutedEventArgs e)
        {

        }
    }
}
