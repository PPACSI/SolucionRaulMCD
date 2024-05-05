import unittest

def MCD(a, b):
    'Calcula el máximo común divisor (MCD) de dos números utilizando el algoritmo de Euclides.'
    while b != 0:
        a, b = b, a % b
    return a

def CuatroNumMCD(n1, n2, n3, n4):
    'Calcula el máximo común divisor (MCD) de cuatro números utilizando la función MCD.'
    mcd_n1_n2 = MCD(n1, n2)
    mcd_n3_n4 = MCD(n3, n4)
    mcd = MCD(mcd_n1_n2, mcd_n3_n4)
    return mcd

class TestMaximoComunDivisor(unittest.TestCase):

    def test_mcd_cuatro_numeros(self):
        'Prueba la función CuatroNumMCD.'
        esperado = 12
        actual = CuatroNumMCD(36, 48, 60, 72)
        self.assertEqual(esperado, actual)

if __name__ == "__main__":
    unittest.main()
