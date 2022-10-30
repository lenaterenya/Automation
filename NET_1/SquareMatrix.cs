using System;

namespace NET_1
{
    public class SquareMatrix<T>
    {
        private protected T[] _matrix;
        private protected int _matrixSize;

        public SquareMatrix(int size)
        {
            _matrixSize = size;
            _matrix = new T[size * size];
        }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize)
                {
                    throw new ArgumentOutOfRangeException($"Update {_matrixSize} - invalid parameters");
                }

                return _matrixSize[(i * _matrixSize) + j];
            }
            set
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize)
                {
                    throw new ArgumentOutOfRangeException($"Update {_matrixSize} - invalid parameters");
                }

                _matrixSize[(i * _matrixSize) + j] = value;
            }
        }
    }
}