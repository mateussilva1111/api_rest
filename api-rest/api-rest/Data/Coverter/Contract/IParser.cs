namespace api_rest.Data.Coverter.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O origin);

        List<D> Parse(List<O> origin);
    }
}
