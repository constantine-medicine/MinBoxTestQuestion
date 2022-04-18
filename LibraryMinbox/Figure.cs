namespace LibraryMinbox
{
    /// <summary>
    /// Перечисление типа фигуры
    /// </summary>
    public enum TypeFigure
    {
        Circle = 1,
        Triangle = 3
    }

    /// <summary>
    /// Класс для взаимодействия с фигурами
    /// </summary>
    public static class Figure
    {
        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        /// <param name="items">Список длин сторон фигуры</param>
        /// <returns>Площадь фигуры</returns>
        /// <exception cref="ArgumentException">Если данных не хватает для работы метода</exception>
        public static double GetArea(List<int> items)
        {
            int count = items.Count;

            switch (count)
            {
                case (int)TypeFigure.Circle:
                    return AreaCircle(items[0]);

                case (int)TypeFigure.Triangle:
                    return AreaTriangle(items);

                default: throw new ArgumentException("Недостаточно данных для определения площади");
            }
        }

        /// <summary>
        /// Получение площади фигуры, по заранее известному типу фигуры
        /// </summary>
        /// <param name="typeFigure">Тип фигуры</param>
        /// <param name="items">Список длин сторон</param>
        /// <returns>Площадь фигуры</returns>
        /// <exception cref="ArgumentException">Если данных не хватает для работы метода</exception>
        public static double GetArea(TypeFigure typeFigure, List<int> items)
        {
            switch (typeFigure)
            {
                case TypeFigure.Circle:
                    return AreaCircle(items[0]);

                case TypeFigure.Triangle:
                    return AreaTriangle(items);

                default: throw new ArgumentException("Недостаточно данных для определения площади");
            }
        }

        /// <summary>
        /// Метод проверяет является ли треугольник прямоугльным
        /// </summary>
        /// <param name="items">Список длин сторон треугольника</param>
        /// <returns>Принадлежность к прямоугольному треугольнику</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsRightTriangle(List<int> items)
        {
            if (items.Count == 3)
            {
                int a = items[0];
                int b = items[1];
                int c = items[2];
                if (a * a + b * b == c * c) return true;
                else if (a * a + c * c == b * b) return true;
                else if (c * c + b * b == a * a) return true;
                else return false;
            }
            else throw new ArgumentException("Эта фигура не является треугольником");
        }

        /// <summary>
        /// Метод проверяет является ли треугольник прямоугольным
        /// </summary>
        /// <param name="typeFigure">Тип фигуры</param>
        /// <param name="items">Список длин сторон треугольника</param>
        /// <returns>Принадлежность к прямоугольному треугольнику</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool IsRightTriangle(TypeFigure typeFigure, List<int> items)
        {
            if (typeFigure == TypeFigure.Triangle)
            {
                int a = items[0];
                int b = items[1];
                int c = items[2];
                if (a * a + b * b == c * c) return true;
                else if (a * a + c * c == b * b) return true;
                else if (c * c + b * b == a * a) return true;
                else return false;
            }
            else throw new ArgumentException("Эта фигура не является треугольником");
        }

        /// <summary>
        /// Считает площадь по радиусу окружгности
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        /// <returns>Площадь, округленную до 6 знаов после запятой</returns>
        private static double AreaCircle(int r) 
        {
            return Math.Round(Math.PI* Math.Pow(r, 2), 6);
        }

        /// <summary>
        /// Считает пощадь через три стороны треугольника
        /// </summary>
        /// <param name="items">Список сторон треугольника</param>
        /// <returns>Площадь, округленную до 6 знаков после запятой</returns>
        private static double AreaTriangle(List<int> items)
        {
            int perimeter = 0;
            foreach (int item in items)
            {
                perimeter += item;
            }
            double p = perimeter / 2;
            var a = p - items[0];
            var b = p - items[1];
            var c  = p - items[2];

            var result = Math.Sqrt(p * a * b * c);
            return Math.Round(result, 6);
        }

    }
}
