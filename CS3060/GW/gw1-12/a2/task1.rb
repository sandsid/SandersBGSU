def foo(arr)
    arr = arr.map{|item| item % 3}
    return arr
end

arra = [4, 6, 6, 2, 12, 67, 34, 9, 11]

arrb = foo(arra)

p arrb