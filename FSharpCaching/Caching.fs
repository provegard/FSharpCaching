module Caching

let memoize f =
    let dict = new System.Collections.Generic.Dictionary<_,_>()
    fun n ->
        match dict.TryGetValue(n) with
        | (true, v) -> v
        | _ ->
            let temp = f(n)
            dict.Add(n, temp)
            temp

type AType(i:int) = class end

let produceWithArg i = 
    new AType(i)
//let produce = produceWithArg

let produceNoArg =
    fun i -> new AType(i)
//let produce = produceNoArg

let produceLazy i =
    lazy(new AType(i))
//let produce i = (produceLazy i).Force()

let produceMem = memoize(fun i ->
    new AType(i) )
let produce = produceMem