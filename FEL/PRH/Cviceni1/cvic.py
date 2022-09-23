def c_to_f(c):
    return (c*9/5)+32


def f_to_c(f):
    return (f-32)*5/9


print(c_to_f(5))

print(f_to_c(35))

print(c_to_f(f_to_c(60)))
