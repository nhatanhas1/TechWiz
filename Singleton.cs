using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public bool IsPersistent;
    protected static T m_Instance;

    public static T Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType<T>();

            }

            return m_Instance;
        }
    }

    protected virtual void Awake()
    {
        if (IsPersistent)
        {
            if (m_Instance == null)
            {
                m_Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else if (m_Instance != this)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            m_Instance = this as T;
        }
    }

    protected virtual void OnDestroy()
    {
        if (m_Instance == this)
        {
            m_Instance = null;
        }
    }
}