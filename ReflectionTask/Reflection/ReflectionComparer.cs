using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Collections;

namespace Reflection
{
    public class ReflectionComparer
    {
        static bool result = true;

        public static bool ReflectionWithComparer(object objectA, object objectB)
        {
            Type objectAType = objectA.GetType();
            Type objectBType = objectB.GetType();
            object valueA;
            object valueB;

            if (objectA == null)
            {
                throw new ArgumentNullException(nameof(objectA));
            }

            if (objectB == null)
            {
                throw new ArgumentNullException(nameof(objectB));
            }

            if (objectA != null && objectB != null)
            {
                if (objectAType != objectBType)
                {
                    return false;                    
                }

                else if (objectA is string)
                {
                    if (String.Compare(objectA.ToString(), objectB.ToString()) == 1 || String.Compare(objectA.ToString(), objectB.ToString()) == -1)
                        return false;
                    else return result;
                }

                else if (objectAType.IsPrimitive)
                    return objectA.Equals(objectB);                

                foreach (PropertyInfo propertyInfo in objectAType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.CanRead))
                {
                    valueA = propertyInfo.GetValue(objectA, null);
                    valueB = propertyInfo.GetValue(objectB, null);

                    if (CanCompareThroughCompareTo(propertyInfo.PropertyType))
                    {
                        if (!AreValuesEqual(valueA, valueB))
                        {
                            Console.WriteLine("Property '{0}.{1}' do not match.", objectAType.FullName, propertyInfo.Name);
                            return false;
                        }
                    }

                    else if (typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType))
                    {
                        IEnumerable<object> collectionItemsOne;
                        IEnumerable<object> collectionItemsTwo;
                        int collectionItemsCountOne;
                        int collectionItemsCountTwo;

                        if (valueA == null && valueB != null || valueA != null && valueB == null)
                        {
                            Console.WriteLine("Property '{0}.{1}' do not match.", objectAType.FullName, propertyInfo.Name);
                            return false;
                        }
                        else if (valueA != null && valueB != null)
                        {
                            collectionItemsOne = ((IEnumerable)valueA).Cast<object>();
                            collectionItemsTwo = ((IEnumerable)valueB).Cast<object>();
                            collectionItemsCountOne = collectionItemsOne.Count();
                            collectionItemsCountTwo = collectionItemsTwo.Count();

                            if (collectionItemsCountOne != collectionItemsCountTwo)
                            {
                                Console.WriteLine("Collection counts for property '{0}.{1}' do not match.", objectAType.FullName, propertyInfo.Name);
                                return false;
                            }
                            else
                            {
                                for (int i = 0; i < collectionItemsCountOne; i++)
                                {
                                    object collectionItem1;
                                    object collectionItem2;
                                    Type collectionItemType;

                                    collectionItem1 = collectionItemsOne.ElementAt(i);
                                    collectionItem2 = collectionItemsTwo.ElementAt(i);
                                    collectionItemType = collectionItem1.GetType();

                                    if (CanCompareThroughCompareTo(collectionItemType))
                                    {
                                        if (!AreValuesEqual(collectionItem1, collectionItem2))
                                        {
                                            Console.WriteLine("Item {0} in property collection '{1}.{2}' does not match.", i, objectAType.FullName, propertyInfo.Name);
                                            return false;
                                        }
                                    }
                                    else if (!ReflectionWithComparer(collectionItem1, collectionItem2))
                                    {
                                        Console.WriteLine("Item {0} in property collection '{1}.{2}' does not match.", i, objectAType.FullName, propertyInfo.Name);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    else if (propertyInfo.PropertyType.IsClass)
                    {
                        if (!ReflectionWithComparer(propertyInfo.GetValue(objectA, null), propertyInfo.GetValue(objectB, null)))
                        {
                            Console.WriteLine("Mismatch with property '{0}.{1}' found.", objectAType.FullName, propertyInfo.Name);
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cannot compare property '{0}.{1}'.", objectAType.FullName, propertyInfo.Name);
                        return false;
                    }
                }                
            }
            return result;
        }

        private static bool CanCompareThroughCompareTo(Type type)
        {
            return typeof(IComparable).IsAssignableFrom(type) || type.IsPrimitive || type.IsValueType;
        }

        private static bool AreValuesEqual(object valueA, object valueB)
        {
            bool result;
            IComparable selfValueComparer;

            selfValueComparer = valueA as IComparable;

            if (valueA == null && valueB != null || valueA != null && valueB == null)
                result = false;
            else if (selfValueComparer != null && selfValueComparer.CompareTo(valueB) != 0)
                result = false;
            else if (!object.Equals(valueA, valueB))
                result = false;            
            else
                result = true;

            return result;
        }
    }
}