namespace NET_1
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public DiagonalMatrix(int size) : base(size)
        {
        }

        public override T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize)
                {
                    throw new ArgumentOutOfRangeException("Can't reach this index");
                }
                else if (i != j)
                {
                    return default;
                }

                return _matrix[i * _matrixSize + j];
            }
            set
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize || i != j )
                {
                    throw new ArgumentOutOfRangeException("Update matrix Element - invalid parameters");
                }

                _matrix[i * _matrixSize + j] = value;
            }
        }
    }
}