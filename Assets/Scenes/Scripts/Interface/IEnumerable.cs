
namespace DSASample.Collections{

    public interface IEnumerable:IEnumerator {
        
        IEnumerator GetEnumerator();
    }
}