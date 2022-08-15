// See https://aka.ms/new-console-template for more information
using Module3;

Matrix matrix = new Matrix(maxElement: 0);

matrix.PrintMatrix();
matrix.SortAscendingByMaxRowElement();
matrix.SortAscendingByMinRowElement();
matrix.SortDescendingByMaxRowElement();
matrix.SortDescendingByMinRowElement();
matrix.SortAscendingByRowSums();
matrix.SortDescendingByRowSums();