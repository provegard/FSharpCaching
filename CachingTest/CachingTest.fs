module CachingTest

open NUnit.Framework
open Caching

[<TestFixture>]
type cachingFixture() = class

    [<Test>]
    member self.cacheWithSameInputTest() =
       let value1 = produce 1
       let value2 = produce 1
       Assert.AreSame (value1, value2)

    [<Test>]
    member self.dontCacheWithDifferentInputsTest() =
       let value1 = produce 1
       let value2 = produce 2
       Assert.AreNotSame (value1, value2)

end

