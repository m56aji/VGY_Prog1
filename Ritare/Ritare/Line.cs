// Är en struct-klass som är en enklare variant av klass som inte kan ärvas
// Den är inte heller en klass som har ngn design och behöver därför ingen designklass
// och sålunda inte delad/partial

using System.Drawing;
using System;

[Serializable]          //Går att spara på fil i en följd, i en serie = serializable
struct Line             
{
    public Point P1, P2;
    public Color Color;

    public Line(Point a, Point b, Color c)
    {
        P1 = a;
        P2 = b;
        Color = c;
    }
}