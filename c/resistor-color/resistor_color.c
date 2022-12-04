#include "resistor_color.h"
#include <stdlib.h>


int color_code(resistor_band_t R) {
    return R;
}
resistor_band_t* colors() {
    resistor_band_t* R = (resistor_band_t*) malloc(10 * sizeof(resistor_band_t));
    for (int i = 0; i < 10; i++) {
        R[i] = i;
    }
    return R;
}
