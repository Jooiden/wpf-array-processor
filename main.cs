using System;using System.Linq;using System.Windows;namespace Курсовик
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] array;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ParseArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                array = ArrayInputTextBox.Text
                    .Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                ArrayStatusTextBlock.Text = $"Массив: {string.Join(", ", array)}";
                SortedArrayTextBlock.Text = "";
                SearchResultTextBlock.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные числа, разделённые запятыми, точками или пробелами.", "Ошибка");
            }
        }

        private void SortArray_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала введите и распарсите массив.", "Ошибка");
                return;
            }

            // пузырьковая сортировка
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            SortedArrayTextBlock.Text = $"Отсортированный массив: {string.Join(", ", array)}";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала распарсите массив.", "Ошибка");
                return;
            }

            if (!int.TryParse(SearchNumberTextBox.Text, out int target))
            {
                MessageBox.Show("Введите корректное число для поиска.", "Ошибка");
                return;
            }

            int index = Array.IndexOf(array, target);
            if (index >= 0)
            {
                SearchResultTextBlock.Text = $"Элемент {target} найден в позиции {index + 1} (считая с 1).";
            }
            else
            {
                SearchResultTextBlock.Text = $"Элемент {target} не найден в массиве.";
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ArrayInputTextBox.Text = "";
            ArrayStatusTextBlock.Text = "Массив не обработан";
            SortedArrayTextBlock.Text = "";
            SearchNumberTextBox.Text = "";
            SearchResultTextBlock.Text = "";
            array = null;
        }
    }
}

новый репозиторий "main.cs"using System;using System.Linq;using System.Windows;namespace Курсовик
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] array;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ParseArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                array = ArrayInputTextBox.Text
                    .Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                ArrayStatusTextBlock.Text = $"Массив: {string.Join(", ", array)}";
                SortedArrayTextBlock.Text = "";
                SearchResultTextBlock.Text = "";
            }
            catch
            {
                MessageBox.Show("Введите корректные числа, разделённые запятыми, точками или пробелами.", "Ошибка");
            }
        }

        private void SortArray_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала введите и распарсите массив.", "Ошибка");
                return;
            }

            // пузырьковая сортировка
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            SortedArrayTextBlock.Text = $"Отсортированный массив: {string.Join(", ", array)}";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала распарсите массив.", "Ошибка");
                return;
            }

            if (!int.TryParse(SearchNumberTextBox.Text, out int target))
            {
                MessageBox.Show("Введите корректное число для поиска.", "Ошибка");
                return;
            }

            int index = Array.IndexOf(array, target);
            if (index >= 0)
            {
                SearchResultTextBlock.Text = $"Элемент {target} найден в позиции {index + 1} (считая с 1).";
            }
            else
            {
                SearchResultTextBlock.Text = $"Элемент {target} не найден в массиве.";
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ArrayInputTextBox.Text = "";
            ArrayStatusTextBlock.Text = "Массив не обработан";
            SortedArrayTextBlock.Text = "";
            SearchNumberTextBox.Text = "";
            SearchResultTextBlock.Text = "";
            array = null;
        }
    }
}
