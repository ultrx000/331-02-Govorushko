def compute_price_reduction(score, item_factor):
    initial_reduction = score / 2
    final_reduction = initial_reduction * item_factor
    return round(final_reduction, 2)