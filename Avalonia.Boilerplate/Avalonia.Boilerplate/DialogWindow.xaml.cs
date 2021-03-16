﻿using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.Boilerplate {
    public class DialogWindow : Window {
        public DialogWindow() {
            InitializeComponent();
        }

        public Task<bool> ShowModalWindow(Window owner) {
            return ShowDialog<bool>(owner);
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
            Content = new Button() {
                Height = 200,
                Width = 200,
                Content = "test content"
            };
            SizeToContent = SizeToContent.WidthAndHeight;
            Padding = new Thickness(Padding.Left, WindowDecorationMargin.Top, Padding.Right, Padding.Bottom);
        }
    }
}