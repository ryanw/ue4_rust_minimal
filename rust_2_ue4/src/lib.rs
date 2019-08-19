use std::os::raw::{c_float, c_int};

#[no_mangle]
pub unsafe extern fn generate_floats(output: *mut *const c_float) -> c_int {
    let mut floats: Vec<c_float> = vec![
        1.2,
        3.4,
        5.6,
        7.8,
        666.123,
        0.345,
        321.123,
    ];
    let count = floats.len();

    floats.shrink_to_fit();
    *output = floats.as_ptr();
    std::mem::forget(floats);

    count as _
}
