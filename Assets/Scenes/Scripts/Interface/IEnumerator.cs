namespace DSASample.Collections{

    public interface IEnumerator {

        bool MoveNext();

        object Current();

        void Reset();
    }
}