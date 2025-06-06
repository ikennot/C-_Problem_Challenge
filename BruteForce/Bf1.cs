using System;

class Bf1{

static int[] findPair(int[] nums,int target)
{

for(int i = 0; i < nums.Length; i++)
{


for(int j = i+1; j < nums.Length;j++)
{


int combine = nums[i]+nums[j];

if(combine == target)
return new int[] {i,j};

}

}

return new int[]{0,0};
}

static void Main()
{

int [] nums={2,7,11,15};
int [] nums1={1,3,5,7};
int target =9;
int target1=10;
int [] ans=findPair(nums,target);
int [] ans1=findPair(nums1,target1);
for(int i = 0; i < ans1.Length;i++)
Console.Write(ans1[i]+" ");
Console.WriteLine();
for(int i = 0; i < ans.Length;i++)
Console.Write(ans[i]+" ");


}

}