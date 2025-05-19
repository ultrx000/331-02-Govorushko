from src.partners_importer import load_partner_data as load_partners
from src.discount_calculator import compute_price_reduction as calculate_discount
import psycopg2

def establish_db_connection():
    return psycopg2.connect(
        host='localhost',
        database='partners',
        user='user',
        password='password'
    )

def main():
    db_connection = establish_db_connection()
    
    partners_file = 'data/partners.csv'
    load_partners(partners_file, db_connection)
    
    rating_value = 7
    product_factor = 2.35
    discount_amount = calculate_discount(rating_value, product_factor)
    
    print(f"Calculated discount: {discount_amount}")

if __name__ == "__main__":
    main()