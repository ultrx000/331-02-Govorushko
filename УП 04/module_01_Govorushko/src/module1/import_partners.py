import csv
import psycopg2
from typing import Dict, Any

def load_partner_data(file_path: str, database_connection) -> None:
    """Загружает данные о партнёрах из CSV файла в базу данных.
    
    Аргументы:
        file_path: Путь к CSV файлу с данными о партнёрах
        database_connection: Активное подключение к базе данных
    """
    PARTNER_FIELDS_MAPPING = {
        'Тип партнера': 'type',
        'Наименование партнера': 'name',
        'Директор': 'director',
        'Электронная почта партнера': 'email',
        'Телефон партнера': 'phone',
        'Юридический адрес партнера': 'address',
        'ИНН': 'inn',
        'Рейтинг': 'rating'
    }

    with open(file_path, mode='r', encoding='utf-8') as data_file:
        data_reader = csv.DictReader(data_file)
        process_partner_records(data_reader, database_connection, PARTNER_FIELDS_MAPPING)

def process_partner_records(
    records: csv.DictReader, 
    db_conn, 
    field_mapping: Dict[str, str]
) -> None:
    """Обрабатывает и добавляет записи о партнёрах в базу данных.

    Аргументы:
        records: Итератор с данными о партнёрах (из CSV)
        db_conn: Подключение к базе данных
        field_mapping: Соответствие полей CSV колонкам в БД (словарь)
    """
    insert_query = '''
        INSERT INTO partners 
            (type, name, director, email, phone, address, inn, rating)
        VALUES 
            (%s, %s, %s, %s, %s, %s, %s, %s)
    '''

    with db_conn.cursor() as cursor:
        for record in records:
            mapped_values = [
                record[source_field] 
                for source_field, _ in field_mapping.items()
            ]
            cursor.execute(insert_query, mapped_values)
    db_conn.commit()