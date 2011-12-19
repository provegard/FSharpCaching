module CachingTest

open NUnit.Framework
open Caching

[<TestFixture>]
type cachingFixture() = class

    [<Test>]
    member self.cacheWithSameInputTest() =
       Assert.AreSame (produce 1, produce 1)

    [<Test>]
    member self.dontCacheWithDifferentInputsTest() =
       Assert.AreNotSame (produce 1, produce 2)

end

