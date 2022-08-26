from django.db import models

""""
Create a class “djangoClasses” within your models.py file. 
It should have the following attributes and include a Model manager:
Title (string value), Course Number (integer value), 
Instructor Name (string value), Duration (float value)
"""

class djangoClasses(models.Model):
    Title = models.CharField(max_length=60)
    CourseNumber = models.IntegerField()
    InstructorName = models.CharField(max_length=60, default="", blank=True, null=True)
    Duration = models.FloatField(blank=True, null=True)

    objects = models.Manager()

    def __str__(self):
        return self.Title

