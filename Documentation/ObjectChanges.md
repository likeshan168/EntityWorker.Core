## ObjectChanges
lets see how EntityWorker gets the changed objects 
```csharp
        using (var rep = new Repository())
            {
                var user = rep.Get<User>().LoadChildren().ExecuteFirstOrDefault();
                user.UserName = "hahahadfsfddfsdfhaha";
                var changes = rep.GetObjectChanges(user); 
                var oldValue = changes.First().OldValue;
                var newValue = changes.First().NewValue;
                var propertyName = changes.First().PropertyName;
                rep.Save(user);
                rep.SaveChanges();
            }

```
