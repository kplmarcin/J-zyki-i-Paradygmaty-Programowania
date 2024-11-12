// for i = 1 to 5 do
//     printfn "wartość i =%d" i

// for i = 1 downto 1 do
//     printfn "wartośc i = %d" i

// let rec sumaRec n=
//     if n <=0 then 0
//     else n + sumaRec(n-1)

// let sumaTail n=
//     let rec sumaRecTail n acc =
//         if n <=0 then acc
//         else n + sumaRec(n-1) (acc + n)
//     sumaRecTail n 0    

// let numbers = [1;2;3;4]
// let numbers1 = List.map (fun x-> x*x) numbers

let rec fib n =
    if n <= 1 then n
    else fib(n-1) + fib(n-2)
