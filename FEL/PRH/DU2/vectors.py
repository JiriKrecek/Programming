
class MyVector:

    def __init__(self, values):
        self.values = values

    def __mul__(self, other):
        if len(self.values) == len(other.values):
            scalar = 0
            for i in range(len(self.values)):
                scalar += self.values[i] * other.values[i]
            return scalar
        else:
            return 0

    def get_vector(self):
        return self.values
        