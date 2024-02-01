תכנון RESTfull API

נושא: בית מלון

תיאור: מערכת לניהול הזמנות בבית מלון לכל מזמין בודקת את התאריך לאירוח וחדר מתאים.

ישויות: אנשים, תאריכים וחדרים.

מיפוי Routes לאנשים:


שליפת רשימת האנשים:
https://hotel/api/person

שליפת נתונים על אדם מסוים:

https://hotel/api/person/{id}
הוספת מזמין לרשימת האנשים:

https://hotel/api/person/{id}
עדכון פרטי מזמין מסוים:

https://hotel/api/person/{id}
מחיקת מזמין:

https://hotel/api/person/{id}
מיפוי Routes לתאריכים:

שליפת רשימת התאריכים:

https://hotel/api/date
שליפת המבקרים בתאריך מסוים:

https://hotel/api/date/{date}
הוספת תאריך חדש לרשימת התאריך:

https://hotel/api/date/{date}
עדכון עובד בתאריך:

https://hotel/api/date/{date}
מיפוי Routes לחדרים:

שליפת רשימת החדרים:

https://hotel/api/room
שליפת נתונים על חדר מסוים:

https://hotel/api/room/{id}
עדכון פרטי חדר מסוים:

 https://hotel/api/room/{id}
