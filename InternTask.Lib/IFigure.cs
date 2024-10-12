namespace InternTask.Lib;

/// <summary>
/// - Легкость добавления других фигур
/// тут не совсем понятно что имеется ввиду, я полагаю просто объявления новых реализаций
/// 
/// - Вычисление площади фигуры без знания типа фигуры в compile-time
/// </summary>
public interface IFigure
{
    double GetSurface();
}