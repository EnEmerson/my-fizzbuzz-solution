# my-fizzbuzz-solution
My short and simple solution to the elusive "fizzbuzz" problem.

---

![fizzbuzz-form](https://github.com/EnEmerson/my-fizzbuzz-solution/blob/master/resources/fizzbuzz-form.png)


```c#

for(int i = 1; i <= count; i++)
{
	if ((i % fizz == 0) && (i % buzz == 0))
		outputBox.Items.Add("fizzbuzz");
	else if (i % fizz == 0)
		outputBox.Items.Add("fizz");
	else if (i % buzz == 0)
		outputBox.Items.Add("buzz");
	else
		outputBox.Items.Add(i.ToString());
}

```

