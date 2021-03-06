namespace jive
{
  public interface Query<out TOutput>
  {
    TOutput fetch();
  }

  public interface Query<in TInput, out TOutput>
  {
    TOutput fetch(TInput item);
  }
}
