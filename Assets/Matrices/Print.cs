using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    private Matrices matrix1 = new Matrices(2,2);
    private Matrices matrix2 = new Matrices(2, 2);
    private Matrices diagnolMatrix = new Matrices(3, 3);
    private Matrices InverseDignolMatrix = new Matrices(3, 3);
    private Matrices multiplyMatrices = new Matrices(2, 2);
    private Matrices sumOfMatrices = new Matrices(2, 2);
    private Matrices differenceOfMatrices = new Matrices(2, 2);

    // Start is called before the first frame update
    void Start()
    {
        matrix1.setElementsInMatrix(0, 0, 2);
        matrix1.setElementsInMatrix(0, 1, 4);
        matrix1.setElementsInMatrix(1, 0, 4);
        matrix1.setElementsInMatrix(1, 1, 6);

        //matrix1.printMatrix();

        matrix2.setElementsInMatrix(0, 0, 1);
        matrix2.setElementsInMatrix(0, 1, 3);
        matrix2.setElementsInMatrix(1, 0, 5);
        matrix2.setElementsInMatrix(1, 1, 7);

        //matrix2.printMatrix();

        //sumOfMatrices.printSum(matrix1, matrix2); //3,7,9,13
        //differenceOfMatrices.printDifference(matrix1, matrix2);//1,1,-1,-1;

        //matrix1.SwappingRows(matrix1, 0, 1);

        //diagnolMatrix.printMatrix();

        diagnolMatrix.setDiagnolMatrix(1);

        InverseDignolMatrix.InverseDiagnolMatrix(1);
        InverseDignolMatrix.printMatrix();

        multiplyMatrices.MultiplyMatrices(matrix1, matrix2);

       // diagnolMatrix.printMatrix();
        //Debug.Log(diagnolMatrix.CheckDiagnolMatrix(diagnolMatrix));
        //Debug.Log(matrix1.CheckDiagnolMatrix(matrix1));

        //Debug.Log(matrix1.getElementInMatrix(0, 1));

    }
}
