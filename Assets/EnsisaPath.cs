using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnsisaPath : MonoBehaviour
{

    //{xDesir�, yD�sir�, emit(1 oui 0 non)} zD�sir� fix� � -7 en fait
    public double[,] path = {
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},
                {-9, 12, 0},


                {-9, 12, 1}, //E
                {-9.5, 12, 1},
                {-10, 12, 1},
                {-10.5, 12, 1},
                {-11, 12, 1},
                {-11.5, 12, 1},
                {-12, 12, 1},
                {-12, 11.5, 1},
                {-12, 11, 1},
                {-12, 10.5, 1},
                {-12, 10, 1},
                {-12, 9.5, 1},
                {-12, 9, 1},
                {-12, 8.5, 1},
                {-12, 8, 1},
                {-11.5, 8, 1},
                {-11, 8, 1},
                {-10.5, 8, 1},
                {-10, 8, 1},
                {-10.5, 8, 1},
                {-11, 8, 1},
                {-11.5, 8, 1},
                {-12, 8, 1},
                {-12, 7.5, 1},
                {-12, 7, 1},
                {-12, 6.5, 1},
                {-12, 6, 1},
                {-12, 5.5, 1},
                {-12, 5, 1},
                {-12, 4.5, 1},
                {-12, 4, 1},
                {-11.5, 4, 1},
                {-11, 4, 1},
                {-10.5, 4, 1},
                {-10, 4, 1},
                {-9.5, 4, 1},
                {-9, 4, 0},  //0 � fin de chaque lettre

                {-8.5, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},
                {-8, 4, 0},

                {-8, 4, 1}, //N
                {-8, 4.5, 1},
                {-8, 5, 1},
                {-8, 5.5, 1},
                {-8, 6, 1},
                {-8, 6.5, 1},
                {-8, 7, 1},
                {-8, 7.5, 1},
                {-8, 8, 1},
                {-8, 8.5, 1},
                {-8, 9, 1},
                {-8, 9.5, 1},
                {-8, 10, 1},
                {-8, 10.5, 1},
                {-8, 11, 1},
                {-7.82, 11.5, 1},
                {-7.67, 12, 1},
                {-7.5, 11.5, 1},
                {-7.33, 11, 1},
                {-7.15, 10.5, 1},
                {-7, 10, 1},
                {-6.82, 9.5, 1},
                {-6.67, 9, 1},
                {-6.50, 8.5, 1},
                {-6.33, 8, 1},
                {-6.15, 7.5, 1},
                {-6, 7, 1},
                {-5.82, 6.5, 1},
                {-5.67, 6, 1},
                {-5.50, 5.5, 1},
                {-5.33, 5, 1},
                {-5.15, 4.5, 1},
                {-5, 4, 1},
                {-5, 4.5, 1},
                {-5, 5, 1},
                {-5, 5.5, 1},
                {-5, 6, 1},
                {-5, 6.5, 1},
                {-5, 7, 1},
                {-5, 7.5, 1},
                {-5, 8, 1},
                {-5, 8.5, 1},
                {-5, 9, 1},
                {-5, 9.5, 1},
                {-5, 10, 1},
                {-5, 10.5, 1},
                {-5, 11, 1},
                {-5, 11.5, 1},
                {-5, 12, 0},

                {-4, 12, 0},
                {-3.5, 11.5, 0},
                {-3, 11, 0},
                {-2.5, 10.5, 0},
                {-2, 10, 0},
                {-1.5, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},
                {-1, 10, 0},

                {-1, 10, 1}, //S    add des points ici pcq la c'est des triangles 0->67 --> 0->40->67  67->100 67->90->100
                {-1.25, 10.5, 1},
                {-1.5, 11, 1},
                {-1.75, 11.4, 1},
                {-2, 11.67, 1},
                {-2.25, 11.90, 1},
                {-2.5, 12, 1},
                {-2.75, 11.90, 1},
                {-3, 11.67, 1},
                {-3.25, 11.40, 1},
                {-3.5, 11, 1},
                {-3.75, 10.5, 1},
                {-4, 10, 1},
                {-3.75, 9.5, 1},
                {-3.5, 9, 1},
                {-3.25, 8.6, 1},
                {-3, 8.33, 1},
                {-2.75, 8.10, 1},
                {-2.5, 8, 1},
                {-2.25, 7.90, 1},
                {-2, 7.67, 1},
                {-1.75, 7.40, 1},
                {-1.5, 7, 1},
                {-1.25, 6.5, 1},
                {-1, 6, 1},
                {-1.25, 5.5, 1},
                {-1.5, 5, 1},
                {-1.75, 4.60, 1},
                {-2, 4.33, 1},
                {-2.25, 4.1, 1},
                {-2.5, 4, 1},
                {-2.75, 4.1, 1},
                {-3, 4.33, 1},
                {-3.25, 4.60, 1},
                {-3.5, 5, 1},
                {-3.75, 5.5, 1},
                {-4, 6, 0},

                {-3, 7, 0},
                {-2.5, 7.5, 0},
                {-2, 8, 0},
                {-1.5, 8.5, 0},
                {-1, 9, 0},
                {-0.5, 9.5, 0},
                {0, 10, 0},
                {0.5, 10.5, 0},
                {1, 11, 0},
                {1.5, 11.5, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},
                {1, 12, 0},

                {1, 12, 1}, //I
                {1, 11.5, 1},
                {1, 11, 1},
                {1, 10.5, 1},
                {1, 10, 1},
                {1, 9.5, 1},
                {1, 9, 1},
                {1, 8.5, 1},
                {1, 8, 1},
                {1, 7.5, 1},
                {1, 7, 1},
                {1, 6.5, 1},
                {1, 6, 1},
                {1, 5.5, 1},
                {1, 5, 1},
                {1, 4.5, 1},
                {1, 4, 0},

                {2, 5, 0},
                {2.5, 5.5, 0},
                {3, 6, 0},
                {3.5, 6.5, 0},
                {4, 7, 0},
                {4.5, 7.5, 0},
                {5, 8, 0},
                {5.5, 8.5, 0},
                {6, 9, 0},
                {6, 9.5, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},
                {6, 10, 0},

                {6, 10, 1}, //S    add des points ici pcq la c'est des triangles 0->67 --> 0->40->67  67->100 67->90->100
                {5.75, 10.5, 1},
                {5.5, 11, 1},
                {5.25, 11.4, 1},
                {5, 11.67, 1},
                {4.75, 11.90, 1},
                {4.5, 12, 1},
                {4.25, 11.90, 1},
                {4, 11.67, 1},
                {3.75, 11.40, 1},
                {3.5, 11, 1},
                {3.25, 10.5, 1},
                {3, 10, 1},
                {3.25, 9.5, 1},
                {3.5, 9, 1},
                {3.75, 8.6, 1},
                {4, 8.33, 1},
                {4.25, 8.10, 1},
                {4.5, 8, 1},
                {4.75, 7.90, 1},
                {5, 7.67, 1},
                {5.25, 7.40, 1},
                {5.5, 7, 1},
                {5.75, 6.5, 1},
                {6, 6, 1},
                {5.75, 5.5, 1},
                {5.5, 5, 1},
                {5.25, 4.60, 1},
                {5, 4.33, 1},
                {4.75, 4.1, 1},
                {4.5, 4, 1},
                {4.25, 4.1, 1},
                {4, 4.33, 1},
                {3.75, 4.60, 1},
                {3.5, 5, 1},
                {3.25, 5.5, 1},
                {3, 6, 0},

                {3, 6, 0},
                {3.5, 5.5, 0},
                {4, 5, 0},
                {4.5, 4.5, 0},
                {5, 4, 0},
                {5.5, 4, 0},
                {6, 4, 0},
                {6.5, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},
                {7, 4, 0},

                {7, 4, 1}, //A
                {7.09375, 4.5, 1},
                {7.1875, 5, 1},
                {7.28125, 5.5, 1},
                {7.375, 6, 1},
                {7.46875, 6.5, 1},
                {7.5625, 7, 1},
                {7.65625, 7.5, 1},
                {7.75, 8, 1},
                {8, 8, 1},
                {8.25, 8, 1},
                {8.5, 8, 1},
                {8.75, 8, 1},
                {9, 8, 1},
                {9.25, 8, 1},
                {9, 8, 1},
                {8.75, 8, 1},
                {8.5, 8, 1},
                {8.25, 8, 1},
                {8, 8, 1},
                {7.75, 8, 1},
                {7.84375, 8.5, 1},
                {7.9375, 9, 1},
                {8.03125, 9.5, 1},
                {8.125, 10, 1},
                {8.21875, 10.5, 1},
                {8.3125, 11, 1},
                {8.40625, 11.5, 1},
                {8.5, 12, 1},
                {8.59375, 11.5, 1},
                {8.6875, 11, 1},
                {8.78125, 10.5, 1},
                {8.875, 10, 1},
                {8.96875, 9.5, 1},
                {9.0625, 9, 1},
                {9.15625, 8.5, 1},
                {9.25, 8, 1},
                {9.34375, 7.5, 1},
                {9.4375, 7, 1},
                {9.53125, 7, 1},
                {9.625, 6, 1},
                {9.71875, 5.5, 1},
                {9.8125, 5, 1},
                {9.90625, 4.5, 1},
                {10, 4, 1},    
                {10, 4, 1},   
                {10, 4, 1},   
                {10, 4, 0}    
            };
    
}
