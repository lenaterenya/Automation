namespace NET_1
{
    public class SquareMatrix<T>
    {
        public delegate bool IndexUpdateDelegate<T>(int i,int j, T oldValue);

        public event IndexUpdateDelegate<T> IndexUpdate;

        private protected T[] _matrix;
        private protected int _matrixSize;

        public SquareMatrix(int size)
        {
            _matrixSize = size;
            _matrix = new T[size * size];
        }

        public virtual T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize)
                {
                    throw new ArgumentOutOfRangeException($"Update {_matrixSize} - invalid parameters");
                }

                return _matrix[i * _matrixSize + j];
            }
            set
            {
                if (i < 0 || j < 0 || i >= _matrixSize || j >= _matrixSize)
                {
                    throw new ArgumentOutOfRangeException($"Update {_matrixSize} - invalid parameters");
                }

                var oldValue = _matrix[i * _matrixSize + j];
                _matrix[i * _matrixSize + j] = value;

                OnMatrixChanged(i,j, oldValue);
            }
        }

        public void OnMatrixChanged(int i, int j, T oldValue)
        {
            IndexUpdate?.Invoke(i,j, oldValue);
        }
    }
}