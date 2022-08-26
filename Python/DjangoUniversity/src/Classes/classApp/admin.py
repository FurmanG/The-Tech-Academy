from django.contrib import admin


"""
Add your model to the admin.py file and register it.
"""
from .models import djangoClasses
admin.site.register(djangoClasses)

